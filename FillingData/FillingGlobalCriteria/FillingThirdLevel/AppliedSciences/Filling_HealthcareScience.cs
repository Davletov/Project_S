using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_HealthcareScience(ref Criteria healthcareScience, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria {Name = "Clinical biochemistry", Tags = "clinical biochemistry,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Cytogenetics", Tags = "cytogenetics,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Cytohematology", Tags = "cytohematology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Cytology", Tags = "cytology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Haemostasiology", Tags = "haemostasiology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Histology", Tags = "histology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Clinical immunology", Tags = "clinical immunology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Clinical microbiology", Tags = "clinical microbiology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Molecular genetics", Tags = "molecular genetics,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Parasitology", Tags = "parasitology,clinical laboratory sciences,clinical pathology,laboratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Clinical Physiology", Tags = "clinical physiology", Parent = healthcareScience},
                new Criteria {Name = "dental hygiene and epidemiology", Tags = "dental hygiene and epidemiology,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Dental surgery", Tags = "dental surgery,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Endodontics", Tags = "endodontics,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Orthodontics", Tags = "orthodontics,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Oral and maxillofacial surgery", Tags = "oral and maxillofacial surgery,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Periodontics", Tags = "periodontics,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Prosthodontics", Tags = "prosthodontics,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Implantology", Tags = "implantology,dentistry", Parent = healthcareScience},
                new Criteria {Name = "Nursing", Tags = "nursing", Parent = healthcareScience},
                new Criteria {Name = "Nursing theory", Tags = "nursing theory", Parent = healthcareScience},
                new Criteria {Name = "Midwifery-Obstetrics", Tags = "midwifery-obstetrics", Parent = healthcareScience},
                new Criteria {Name = "Nutrition and dietetics", Tags = "nutrition,dietetics", Parent = healthcareScience},
                new Criteria {Name = "Optometry", Tags = "optometry", Parent = healthcareScience},
                new Criteria {Name = "Orthoptics", Tags = "orthoptics", Parent = healthcareScience},
                new Criteria {Name = "Physiotherapy", Tags = "physiotherapy", Parent = healthcareScience},
                new Criteria {Name = "Occupational therapy", Tags = "occupational therapy", Parent = healthcareScience},
                new Criteria {Name = "Speech and language pathology", Tags = "speech and language pathology", Parent = healthcareScience},
                new Criteria {Name = "Preventive medicine", Tags = "preventive medicine,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Cardiology", Tags = "cardiology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Dermatology", Tags = "dermatology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Pulmonology", Tags = "pulmonology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Medical toxicology", Tags = "medical toxicology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Endocrinology", Tags = "endocrinology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Gastroenterology", Tags = "gastroenterology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Hepatology", Tags = "hepatology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Oncology", Tags = "oncology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Geriatrics", Tags = "geriatrics,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Gynaecology", Tags = "gynaecology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Hematology", Tags = "hematology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Infectious disease", Tags = "infectious disease,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Nephrology", Tags = "nephrology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Neurology", Tags = "neurology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Neurosurgery", Tags = "neurosurgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Obstetrics", Tags = "obstetrics,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Ophthalmology", Tags = "ophthalmology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Orthopedic surgery", Tags = "orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Hand surgery", Tags = "hand surgery,orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Foot and ankle surgery", Tags = "foot and ankle surgery,orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Sports medicine", Tags = "sports medicine,orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Joint replacement", Tags = "joint replacement,orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Shoulder surgery", Tags = "shoulder surgery,orthopedic surgery,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Otolaryngology", Tags = "otolaryngology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Pathology", Tags = "pathology,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Pediatrics", Tags = "pediatrics,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Pharmacy", Tags = "pharmacy,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Pharmaceutical sciences", Tags = "pharmaceutical sciences,internal medicine", Parent = healthcareScience},
                new Criteria {Name = "Group Fitness/aerobics", Tags = "group fitness,aerobics,physical fitness", Parent = healthcareScience},
                new Criteria {Name = "Personal fitness training", Tags = "personal fitness training,physical fitness", Parent = healthcareScience},
                new Criteria {Name = "Kinesiology/Exercise science/Human performance", Tags = "kinesiology,exercise science,human performance,physical fitness", Parent = healthcareScience},
                new Criteria {Name = "Podiatry", Tags = "podiatry", Parent = healthcareScience},
                new Criteria {Name = "Primary care", Tags = "primary care", Parent = healthcareScience},
                new Criteria {Name = "General practice", Tags = "general practice", Parent = healthcareScience},
                new Criteria {Name = "Psychiatry", Tags = "psychiatry", Parent = healthcareScience},
                new Criteria {Name = "Addiction medicine", Tags = "addiction medicine", Parent = healthcareScience},
                new Criteria {Name = "Behavioral medicine", Tags = "behavioral medicine,psychology", Parent = healthcareScience},
                new Criteria {Name = "Clinical psychology", Tags = "clinical psychology,psychology", Parent = healthcareScience},
                new Criteria {Name = "Health psychology", Tags = "health psychology,psychology", Parent = healthcareScience},
                new Criteria {Name = "Medical psychology", Tags = "medical psychology,psychology", Parent = healthcareScience},
                new Criteria {Name = "Counseling psychology", Tags = "counseling psychology,psychology", Parent = healthcareScience},
                new Criteria {Name = "Public health", Tags = "public health", Parent = healthcareScience},
                new Criteria {Name = "Radiology", Tags = "radiology", Parent = healthcareScience},
                new Criteria {Name = "Recreation therapy", Tags = "recreation therapy", Parent = healthcareScience},
                new Criteria {Name = "Rehabilitation medicine", Tags = "rehabilitation medicine", Parent = healthcareScience},
                new Criteria {Name = "Pulmonology", Tags = "pulmonology,respiratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Sleep medicine", Tags = "sleep medicine,respiratory medicine", Parent = healthcareScience},
                new Criteria {Name = "Respiratory therapy", Tags = "respiratory therapy", Parent = healthcareScience},
                new Criteria {Name = "Rheumatology", Tags = "rheumatology", Parent = healthcareScience},
                new Criteria {Name = "Sports medicine", Tags = "sports medicine", Parent = healthcareScience},
                new Criteria {Name = "Bariatric surgery", Tags = "bariatric surgery,surgery", Parent = healthcareScience},
                new Criteria {Name = "Cardiothoracic surgery", Tags = "cardiothoracic surgery,surgery", Parent = healthcareScience},
                new Criteria {Name = "Neurosurgery", Tags = "neurosurgery,surgery", Parent = healthcareScience},
                new Criteria {Name = "Plastic surgery", Tags = "plastic surgery,surgery", Parent = healthcareScience},
                new Criteria {Name = "Traumatology", Tags = "traumatology,surgery", Parent = healthcareScience},
                new Criteria {Name = "Urology", Tags = "urology", Parent = healthcareScience},
                new Criteria {Name = "Andrology", Tags = "andrology", Parent = healthcareScience},
                new Criteria {Name = "Veterinary medicine", Tags = "veterinary medicine", Parent = healthcareScience}
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                healthcareScience.Children.Add(thirdLevelCriteria);
            }
        }
    }
}



