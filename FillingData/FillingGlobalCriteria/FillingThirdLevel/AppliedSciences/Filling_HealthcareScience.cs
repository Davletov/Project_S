namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    using Web.UnitOfWork;

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_HealthcareScience(ref SecondLevelCriteria healthcareScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria {Name = "Clinical biochemistry", Tags = "clinical biochemistry,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Cytogenetics", Tags = "cytogenetics,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Cytohematology", Tags = "cytohematology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Cytology", Tags = "cytology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Haemostasiology", Tags = "haemostasiology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Histology", Tags = "histology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Clinical immunology", Tags = "clinical immunology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Clinical microbiology", Tags = "clinical microbiology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Molecular genetics", Tags = "molecular genetics,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Parasitology", Tags = "parasitology,clinical laboratory sciences,clinical pathology,laboratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Clinical Physiology", Tags = "clinical physiology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "dental hygiene and epidemiology", Tags = "dental hygiene and epidemiology,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Dental surgery", Tags = "dental surgery,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Endodontics", Tags = "endodontics,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Orthodontics", Tags = "orthodontics,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Oral and maxillofacial surgery", Tags = "oral and maxillofacial surgery,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Periodontics", Tags = "periodontics,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Prosthodontics", Tags = "prosthodontics,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Implantology", Tags = "implantology,dentistry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Nursing", Tags = "nursing", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Nursing theory", Tags = "nursing theory", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Midwifery-Obstetrics", Tags = "midwifery-obstetrics", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Nutrition and dietetics", Tags = "nutrition,dietetics", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Optometry", Tags = "optometry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Orthoptics", Tags = "orthoptics", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Physiotherapy", Tags = "physiotherapy", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Occupational therapy", Tags = "occupational therapy", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Speech and language pathology", Tags = "speech and language pathology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Preventive medicine", Tags = "preventive medicine,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Cardiology", Tags = "cardiology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Dermatology", Tags = "dermatology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pulmonology", Tags = "pulmonology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Medical toxicology", Tags = "medical toxicology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Endocrinology", Tags = "endocrinology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Gastroenterology", Tags = "gastroenterology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Hepatology", Tags = "hepatology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Oncology", Tags = "oncology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Geriatrics", Tags = "geriatrics,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Gynaecology", Tags = "gynaecology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Hematology", Tags = "hematology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Infectious disease", Tags = "infectious disease,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Nephrology", Tags = "nephrology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Neurology", Tags = "neurology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Neurosurgery", Tags = "neurosurgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Obstetrics", Tags = "obstetrics,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Ophthalmology", Tags = "ophthalmology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Orthopedic surgery", Tags = "orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Hand surgery", Tags = "hand surgery,orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Foot and ankle surgery", Tags = "foot and ankle surgery,orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Sports medicine", Tags = "sports medicine,orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Joint replacement", Tags = "joint replacement,orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Shoulder surgery", Tags = "shoulder surgery,orthopedic surgery,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Otolaryngology", Tags = "otolaryngology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pathology", Tags = "pathology,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pediatrics", Tags = "pediatrics,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pharmacy", Tags = "pharmacy,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pharmaceutical sciences", Tags = "pharmaceutical sciences,internal medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Group Fitness/aerobics", Tags = "group fitness,aerobics,physical fitness", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Personal fitness training", Tags = "personal fitness training,physical fitness", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Kinesiology/Exercise science/Human performance", Tags = "kinesiology,exercise science,human performance,physical fitness", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Podiatry", Tags = "podiatry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Primary care", Tags = "primary care", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "General practice", Tags = "general practice", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Psychiatry", Tags = "psychiatry", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Addiction medicine", Tags = "addiction medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Behavioral medicine", Tags = "behavioral medicine,psychology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Clinical psychology", Tags = "clinical psychology,psychology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Health psychology", Tags = "health psychology,psychology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Medical psychology", Tags = "medical psychology,psychology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Counseling psychology", Tags = "counseling psychology,psychology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Public health", Tags = "public health", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Radiology", Tags = "radiology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Recreation therapy", Tags = "recreation therapy", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Rehabilitation medicine", Tags = "rehabilitation medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Pulmonology", Tags = "pulmonology,respiratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Sleep medicine", Tags = "sleep medicine,respiratory medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Respiratory therapy", Tags = "respiratory therapy", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Rheumatology", Tags = "rheumatology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Sports medicine", Tags = "sports medicine", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Bariatric surgery", Tags = "bariatric surgery,surgery", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Cardiothoracic surgery", Tags = "cardiothoracic surgery,surgery", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Neurosurgery", Tags = "neurosurgery,surgery", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Plastic surgery", Tags = "plastic surgery,surgery", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Traumatology", Tags = "traumatology,surgery", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Urology", Tags = "urology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Andrology", Tags = "andrology", SecondLevelCriteria = healthcareScience},
                new ThirdLevelCriteria {Name = "Veterinary medicine", Tags = "veterinary medicine", SecondLevelCriteria = healthcareScience}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.ThirdLevelCriteriaRepository.Add(thirdLevelCriteria);
                healthcareScience.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}



