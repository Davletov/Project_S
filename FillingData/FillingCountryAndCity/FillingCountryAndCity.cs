namespace FiilingData
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.VisualBasic.FileIO;
    using Web.Models.Location;
    using Web.UnitOfWork;

    public class FillingCountryAndCity
    {
        public static void FillingCountriesWithCities()
        {
            var stopWatch = new Stopwatch();
            Console.WriteLine("\nПарсим файлы со странами и городами ...");

            stopWatch.Start();

            var countryList = new List<Country>();
            var countOfBadRowsInCountry = 0;

            // Парсим csv файл c значениями стран
            using (var parser = new TextFieldParser(@"D:\Progamming\Project S\docs\Country.csv", System.Text.Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    if (fields != null && fields.Count() > 5)
                    {
                        if (fields[4] != string.Empty && fields[5] != string.Empty)
                        {
                            var country = new Country { ShortName = fields[4], Name = fields[5] };
                            countryList.Add(country);
                        }

                        // кол-во строк с неполной информацией
                        if (fields[4] == string.Empty && fields[5] != string.Empty
                            || fields[4] != string.Empty && fields[5] == string.Empty)
                        {
                            ++countOfBadRowsInCountry;
                        }

                    }
                }
            }

            // Формируем список стран (убираем дубликаты, дубликатов в csv файле много, 
            // т.к. это файл IP кодов для стран, строки с одинаковыми странами дублируются)
            var groupCountryList =
                countryList.OrderBy(x => x.ShortName).Select(x => new {x.ShortName, x.Name})
                    .GroupBy(x => x.ShortName)
                    .Select(x => new Country {ShortName = x.Key, Name = x.Select(y => y.Name).FirstOrDefault()})
                    .ToList();



            var cityList = new List<City>();
            var countOfBadRowsInCity = 0;
            // Парсим csv файл c значениями городов
            using (var parser = new TextFieldParser(@"D:\Progamming\Project S\docs\City.csv", System.Text.Encoding.UTF8))
            {
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadLine().Replace("\"", "").Split(',');
                    if (fields.Count() > 3)
                    {
                        if (fields[1] != string.Empty && fields[3] != string.Empty && fields[3] != "_")
                        {
                            char[] charsToTrim = { '`', ' ', '(', ')' };
                            var cleanName = fields[3].Trim(charsToTrim);
                            var city = new City { ShortNameCountry = fields[1], Name = cleanName };
                            cityList.Add(city);
                        }

                        // кол-во строк с неполной информацией
                        if (fields[1] == string.Empty && fields[3] != string.Empty
                            || fields[1] != string.Empty && fields[3] == string.Empty)
                        {
                            ++countOfBadRowsInCity;
                        }

                    }
                }
            }


            Console.WriteLine("\nПарсинг файлов со странами и городами завершен.");

            // Формируем список стран (убираем дубликаты, дубликатов в csv файле много, 
            // т.к. это файл IP кодов для стран, строки с одинаковыми странами дублируются)
            var groupCityList =
                cityList.OrderBy(x => x.Name).Select(x => new { x.ShortNameCountry, x.Name })
                    .GroupBy(x => x.Name)
                    .Select(x => new City { Name = x.Key, ShortNameCountry = x.Select(y => y.ShortNameCountry).FirstOrDefault() })
                    .ToList();


            Console.WriteLine("\nСохраняем данные со странами и городами в базе ...");

            // Если есть данные в таблице Country, то удалим их
            using (var uow = new UnitOfWork())
            {
                var countruIdsInRepo = uow.CountryRepository.Get().Select(x => x.CountryId).ToList();
                var countCountryInRepo = countruIdsInRepo.Count();
                if (countCountryInRepo > 0)
                {
                    foreach (var country in countruIdsInRepo)
                    {
                        uow.CountryRepository.Delete(country);
                    }
                    uow.Save();
                }
            }

            using (var uow = new UnitOfWork())
            {
                foreach (var country in groupCountryList)
                {
                    var selectCities = groupCityList.Where(x => x.ShortNameCountry == country.ShortName).ToList();
                    country.Cities = selectCities;
                    uow.CountryRepository.Add(country);

                    uow.Save();
                }
            }

            stopWatch.Stop();
            Console.WriteLine("\nДанные со странами и городами успешно сохранены в базе.");

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

    }

}