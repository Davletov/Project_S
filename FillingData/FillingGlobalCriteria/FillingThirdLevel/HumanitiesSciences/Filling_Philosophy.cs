using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Philosophy(ref SecondLevelCriteria philosophy, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Meta-philosophy", Tags = "meta-philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Teleology", Tags = "teleology,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of mind", Tags = "philosophy of mind,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of artificial intelligence", Tags = "philosophy of artificial intelligence,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of perception", Tags = "philosophy of perception,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of pain", Tags = "philosophy of pain,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of space and time", Tags = "philosophy of space and time,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of Action", Tags = "philosophy of action,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Theism and Atheism", Tags = "theism and atheism,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Determinism and Free will", Tags = "determinism and free will,metaphysics,ontology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Justification", Tags = "justification,epistemology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Reasoning errors", Tags = "reasoning errors,epistemology", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Meta-ethics", Tags = "meta-ethics,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Normative ethics", Tags = "normative ethics,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Animal rights", Tags = "animal rights,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Bioethics", Tags = "bioethics,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Environmental ethics", Tags = "environmental ethics,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Moral psychology, Descriptive ethics, Value theory", Tags = "moral psychology,descriptive ethics,value theory,ethics", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Aesthetics", Tags = "aesthetics,philosophy of art", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Feminist philosophy", Tags = "feminist philosophy,social philosophy,political philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Anarchism", Tags = "anarchism,social philosophy,political philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Marxism", Tags = "marxism,social philosophy,political philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "African philosophy", Tags = "african philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Platonism", Tags = "platonism", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Aristotelianism", Tags = "aristotelianism", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Analytic philosophy", Tags = "analytic philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Continental philosophy", Tags = "continental philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Eastern philosophy", Tags = "eastern philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Feminist philosophy", Tags = "feminist philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Ancient philosophy", Tags = "ancient philosophy,history of philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Scholasticism", Tags = "scholasticism,medieval philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Humanism", Tags = "humanism,medieval philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Modern philosophy", Tags = "modern philosophy,history of philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Contemporary philosophy", Tags = "contemporary philosophy,history of philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophical logic", Tags = "philosophical logic", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Mathematical logic", Tags = "mathematical logic", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of education", Tags = "philosophy of education,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of history", Tags = "philosophy of history,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of religion", Tags = "philosophy of religion,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of language", Tags = "philosophy of language,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of law", Tags = "philosophy of law,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of mathematics", Tags = "philosophy of mathematics,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of music", Tags = "philosophy of music,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of engineering", Tags = "philosophy of engineering,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Systems philosophy", Tags = "systems philosophy,applied philosophy", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of social science", Tags = "philosophy of social science,philosophy of science", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of physics", Tags = "philosophy of physics,philosophy of science", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of biology", Tags = "philosophy of biology,philosophy of science", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of chemistry", Tags = "philosophy of chemistry,philosophy of science", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of economics", Tags = "philosophy of economics,philosophy of science", SecondLevelCriteria = philosophy },
                new ThirdLevelCriteria { Name = "Philosophy of psychology", Tags = "philosophy of psychology,philosophy of science", SecondLevelCriteria = philosophy }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                philosophy.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}