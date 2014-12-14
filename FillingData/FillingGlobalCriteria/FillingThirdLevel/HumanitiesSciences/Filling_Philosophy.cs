using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;
    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_Philosophy(ref Criteria philosophy, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Meta-philosophy", Tags = "meta-philosophy", Parent = philosophy },
                new Criteria { Name = "Teleology", Tags = "teleology,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of mind", Tags = "philosophy of mind,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of artificial intelligence", Tags = "philosophy of artificial intelligence,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of perception", Tags = "philosophy of perception,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of pain", Tags = "philosophy of pain,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of space and time", Tags = "philosophy of space and time,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Philosophy of Action", Tags = "philosophy of action,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Theism and Atheism", Tags = "theism and atheism,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Determinism and Free will", Tags = "determinism and free will,metaphysics,ontology", Parent = philosophy },
                new Criteria { Name = "Justification", Tags = "justification,epistemology", Parent = philosophy },
                new Criteria { Name = "Reasoning errors", Tags = "reasoning errors,epistemology", Parent = philosophy },
                new Criteria { Name = "Meta-ethics", Tags = "meta-ethics,ethics", Parent = philosophy },
                new Criteria { Name = "Normative ethics", Tags = "normative ethics,ethics", Parent = philosophy },
                new Criteria { Name = "Animal rights", Tags = "animal rights,ethics", Parent = philosophy },
                new Criteria { Name = "Bioethics", Tags = "bioethics,ethics", Parent = philosophy },
                new Criteria { Name = "Environmental ethics", Tags = "environmental ethics,ethics", Parent = philosophy },
                new Criteria { Name = "Moral psychology, Descriptive ethics, Value theory", Tags = "moral psychology,descriptive ethics,value theory,ethics", Parent = philosophy },
                new Criteria { Name = "Aesthetics", Tags = "aesthetics,philosophy of art", Parent = philosophy },
                new Criteria { Name = "Feminist philosophy", Tags = "feminist philosophy,social philosophy,political philosophy", Parent = philosophy },
                new Criteria { Name = "Anarchism", Tags = "anarchism,social philosophy,political philosophy", Parent = philosophy },
                new Criteria { Name = "Marxism", Tags = "marxism,social philosophy,political philosophy", Parent = philosophy },
                new Criteria { Name = "African philosophy", Tags = "african philosophy", Parent = philosophy },
                new Criteria { Name = "Platonism", Tags = "platonism", Parent = philosophy },
                new Criteria { Name = "Aristotelianism", Tags = "aristotelianism", Parent = philosophy },
                new Criteria { Name = "Analytic philosophy", Tags = "analytic philosophy", Parent = philosophy },
                new Criteria { Name = "Continental philosophy", Tags = "continental philosophy", Parent = philosophy },
                new Criteria { Name = "Eastern philosophy", Tags = "eastern philosophy", Parent = philosophy },
                new Criteria { Name = "Feminist philosophy", Tags = "feminist philosophy", Parent = philosophy },
                new Criteria { Name = "Ancient philosophy", Tags = "ancient philosophy,history of philosophy", Parent = philosophy },
                new Criteria { Name = "Scholasticism", Tags = "scholasticism,medieval philosophy", Parent = philosophy },
                new Criteria { Name = "Humanism", Tags = "humanism,medieval philosophy", Parent = philosophy },
                new Criteria { Name = "Modern philosophy", Tags = "modern philosophy,history of philosophy", Parent = philosophy },
                new Criteria { Name = "Contemporary philosophy", Tags = "contemporary philosophy,history of philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophical logic", Tags = "philosophical logic", Parent = philosophy },
                new Criteria { Name = "Mathematical logic", Tags = "mathematical logic", Parent = philosophy },
                new Criteria { Name = "Philosophy of education", Tags = "philosophy of education,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of history", Tags = "philosophy of history,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of religion", Tags = "philosophy of religion,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of language", Tags = "philosophy of language,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of law", Tags = "philosophy of law,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of mathematics", Tags = "philosophy of mathematics,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of music", Tags = "philosophy of music,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of engineering", Tags = "philosophy of engineering,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Systems philosophy", Tags = "systems philosophy,applied philosophy", Parent = philosophy },
                new Criteria { Name = "Philosophy of social science", Tags = "philosophy of social science,philosophy of science", Parent = philosophy },
                new Criteria { Name = "Philosophy of physics", Tags = "philosophy of physics,philosophy of science", Parent = philosophy },
                new Criteria { Name = "Philosophy of biology", Tags = "philosophy of biology,philosophy of science", Parent = philosophy },
                new Criteria { Name = "Philosophy of chemistry", Tags = "philosophy of chemistry,philosophy of science", Parent = philosophy },
                new Criteria { Name = "Philosophy of economics", Tags = "philosophy of economics,philosophy of science", Parent = philosophy },
                new Criteria { Name = "Philosophy of psychology", Tags = "philosophy of psychology,philosophy of science", Parent = philosophy }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                philosophy.Children.Add(thirdLevelCriteria);
            }
        }
    }
}