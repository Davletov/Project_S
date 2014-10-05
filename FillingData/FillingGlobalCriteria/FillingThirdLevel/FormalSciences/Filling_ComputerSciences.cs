using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ComputerSciences(ref SecondLevelCriteria computerSciences, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Automata theory", Tags = "automata theory,formal languages,theory of computation", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computability theory", Tags = "computability theory,theory of computation", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational complexity theory", Tags = "computational complexity theory,theory of computation", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Concurrency theory", Tags = "concurrency theory,theory of computation", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "VLSI design", Tags = "VLSI design", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Operating systems", Tags = "operating systems", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Randomized algorithms", Tags = "randomized algorithms,algorithms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Distributed algorithms", Tags = "distributed algorithms,algorithms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Parallel algorithms", Tags = "parallel algorithms,algorithms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational geometry", Tags = "computational geometry,algorithms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Data structures", Tags = "data structures", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computer architecture", Tags = "computer architecture", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Information theory", Tags = "information theory,computer communications,networks", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Internet, World wide web", Tags = "internet, world wide web,computer communications,networks", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Wireless computing", Tags = "wireless computing,mobile computing,computer communications,networks", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Ubiquitous computing", Tags = "ubiquitous computing,computer communications,networks", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Cloud computing", Tags = "cloud computing,computer communications,networks", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Cryptography", Tags = "cryptography,computer security and reliability", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Fault-tolerant computing", Tags = "fault-tolerant computing,computer security and reliability", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Grid computing", Tags = "grid computing,distributed computing", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "High-performance computing", Tags = "high-performance computing,parallel computing", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Quantum computing", Tags = "quantum computing", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Image processing", Tags = "image processing,computer graphics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Scientific visualization", Tags = "scientific visualization,computer graphics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Formal methods", Tags = "formal methods,software engineering", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Programming languages", Tags = "programming languages", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Imperative programming", Tags = "imperative programming,programming paradigms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Object-oriented programming", Tags = "object-oriented programming,programming paradigms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Functional programming", Tags = "functional programming,programming paradigms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Logic programming", Tags = "logic programming,programming paradigms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Concurrent programming", Tags = "concurrent programming,programming paradigms", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Program semantics", Tags = "program semantics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Type theory", Tags = "type theory", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Compilers", Tags = "compilers", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Human-computer interaction", Tags = "human-computer interaction", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Information science", Tags = "information science", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Data management", Tags = "data management", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Data mining", Tags = "data mining", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Relational database", Tags = "relational database,database", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Distributed database", Tags = "distributed database,database", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Object database", Tags = "object database,database", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Information retrieval", Tags = "information retrieval", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Information management", Tags = "information management", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Knowledge management", Tags = "knowledge management", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Multimedia, hypermedia", Tags = "multimedia,hypermedia", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Sound and music computing", Tags = "sound and music computing", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Cognitive science", Tags = "cognitive science,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Automated reasoning", Tags = "automated reasoning,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Machine learning", Tags = "machine learning,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Artificial neural network", Tags = "artificial neural network,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Support vector machine", Tags = "support vector machine,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Natural language processing", Tags = "natural language processing,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computer vision", Tags = "computer vision,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Expert systems", Tags = "expert systems,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Robotics", Tags = "robotics,artificial intelligence", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Numerical analysis", Tags = "numerical analysis", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Algebraic computation", Tags = "algebraic computation,symbolic computation", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational number theory", Tags = "computational number theory", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational mathematics", Tags = "computational mathematics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Scientific computing", Tags = "scientific computing,computational science", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational biology", Tags = "computational biology,bioinformatics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational physics", Tags = "computational physics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational chemistry", Tags = "computational chemistry", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational neuroscience", Tags = "computational neuroscience", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computer-aided engineering", Tags = "computer-aided engineering", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Finite element analysis", Tags = "finite element analysis", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational fluid dynamics", Tags = "computational fluid dynamics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational economics", Tags = "computational economics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational sociology", Tags = "computational sociology", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Computational finance", Tags = "computational finance", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "The Digital Humanities", Tags = "the digital humanities,humanities computing", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "History of computer hardware", Tags = "history of computer hardware", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "History of computer science", Tags = "history of computer science", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Humanistic informatics", Tags = "humanistic informatics", SecondLevelCriteria = computerSciences },
                new ThirdLevelCriteria { Name = "Community informatics", Tags = "community informatics", SecondLevelCriteria = computerSciences }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                computerSciences.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}