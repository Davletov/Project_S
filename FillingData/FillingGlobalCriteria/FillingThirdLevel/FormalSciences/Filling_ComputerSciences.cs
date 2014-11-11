using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_ComputerSciences(ref Criteria computerSciences, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Automata theory", Tags = "automata theory,formal languages,theory of computation", Parent = computerSciences },
                new Criteria { Name = "Computability theory", Tags = "computability theory,theory of computation", Parent = computerSciences },
                new Criteria { Name = "Computational complexity theory", Tags = "computational complexity theory,theory of computation", Parent = computerSciences },
                new Criteria { Name = "Concurrency theory", Tags = "concurrency theory,theory of computation", Parent = computerSciences },
                new Criteria { Name = "VLSI design", Tags = "VLSI design", Parent = computerSciences },
                new Criteria { Name = "Operating systems", Tags = "operating systems", Parent = computerSciences },
                new Criteria { Name = "Randomized algorithms", Tags = "randomized algorithms,algorithms", Parent = computerSciences },
                new Criteria { Name = "Distributed algorithms", Tags = "distributed algorithms,algorithms", Parent = computerSciences },
                new Criteria { Name = "Parallel algorithms", Tags = "parallel algorithms,algorithms", Parent = computerSciences },
                new Criteria { Name = "Computational geometry", Tags = "computational geometry,algorithms", Parent = computerSciences },
                new Criteria { Name = "Data structures", Tags = "data structures", Parent = computerSciences },
                new Criteria { Name = "Computer architecture", Tags = "computer architecture", Parent = computerSciences },
                new Criteria { Name = "Information theory", Tags = "information theory,computer communications,networks", Parent = computerSciences },
                new Criteria { Name = "Internet, World wide web", Tags = "internet, world wide web,computer communications,networks", Parent = computerSciences },
                new Criteria { Name = "Wireless computing", Tags = "wireless computing,mobile computing,computer communications,networks", Parent = computerSciences },
                new Criteria { Name = "Ubiquitous computing", Tags = "ubiquitous computing,computer communications,networks", Parent = computerSciences },
                new Criteria { Name = "Cloud computing", Tags = "cloud computing,computer communications,networks", Parent = computerSciences },
                new Criteria { Name = "Cryptography", Tags = "cryptography,computer security and reliability", Parent = computerSciences },
                new Criteria { Name = "Fault-tolerant computing", Tags = "fault-tolerant computing,computer security and reliability", Parent = computerSciences },
                new Criteria { Name = "Grid computing", Tags = "grid computing,distributed computing", Parent = computerSciences },
                new Criteria { Name = "High-performance computing", Tags = "high-performance computing,parallel computing", Parent = computerSciences },
                new Criteria { Name = "Quantum computing", Tags = "quantum computing", Parent = computerSciences },
                new Criteria { Name = "Image processing", Tags = "image processing,computer graphics", Parent = computerSciences },
                new Criteria { Name = "Scientific visualization", Tags = "scientific visualization,computer graphics", Parent = computerSciences },
                new Criteria { Name = "Formal methods", Tags = "formal methods,software engineering", Parent = computerSciences },
                new Criteria { Name = "Programming languages", Tags = "programming languages", Parent = computerSciences },
                new Criteria { Name = "Imperative programming", Tags = "imperative programming,programming paradigms", Parent = computerSciences },
                new Criteria { Name = "Object-oriented programming", Tags = "object-oriented programming,programming paradigms", Parent = computerSciences },
                new Criteria { Name = "Functional programming", Tags = "functional programming,programming paradigms", Parent = computerSciences },
                new Criteria { Name = "Logic programming", Tags = "logic programming,programming paradigms", Parent = computerSciences },
                new Criteria { Name = "Concurrent programming", Tags = "concurrent programming,programming paradigms", Parent = computerSciences },
                new Criteria { Name = "Program semantics", Tags = "program semantics", Parent = computerSciences },
                new Criteria { Name = "Type theory", Tags = "type theory", Parent = computerSciences },
                new Criteria { Name = "Compilers", Tags = "compilers", Parent = computerSciences },
                new Criteria { Name = "Human-computer interaction", Tags = "human-computer interaction", Parent = computerSciences },
                new Criteria { Name = "Information science", Tags = "information science", Parent = computerSciences },
                new Criteria { Name = "Data management", Tags = "data management", Parent = computerSciences },
                new Criteria { Name = "Data mining", Tags = "data mining", Parent = computerSciences },
                new Criteria { Name = "Relational database", Tags = "relational database,database", Parent = computerSciences },
                new Criteria { Name = "Distributed database", Tags = "distributed database,database", Parent = computerSciences },
                new Criteria { Name = "Object database", Tags = "object database,database", Parent = computerSciences },
                new Criteria { Name = "Information retrieval", Tags = "information retrieval", Parent = computerSciences },
                new Criteria { Name = "Information management", Tags = "information management", Parent = computerSciences },
                new Criteria { Name = "Knowledge management", Tags = "knowledge management", Parent = computerSciences },
                new Criteria { Name = "Multimedia, hypermedia", Tags = "multimedia,hypermedia", Parent = computerSciences },
                new Criteria { Name = "Sound and music computing", Tags = "sound and music computing", Parent = computerSciences },
                new Criteria { Name = "Cognitive science", Tags = "cognitive science,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Automated reasoning", Tags = "automated reasoning,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Machine learning", Tags = "machine learning,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Artificial neural network", Tags = "artificial neural network,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Support vector machine", Tags = "support vector machine,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Natural language processing", Tags = "natural language processing,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Computer vision", Tags = "computer vision,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Expert systems", Tags = "expert systems,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Robotics", Tags = "robotics,artificial intelligence", Parent = computerSciences },
                new Criteria { Name = "Numerical analysis", Tags = "numerical analysis", Parent = computerSciences },
                new Criteria { Name = "Algebraic computation", Tags = "algebraic computation,symbolic computation", Parent = computerSciences },
                new Criteria { Name = "Computational number theory", Tags = "computational number theory", Parent = computerSciences },
                new Criteria { Name = "Computational mathematics", Tags = "computational mathematics", Parent = computerSciences },
                new Criteria { Name = "Scientific computing", Tags = "scientific computing,computational science", Parent = computerSciences },
                new Criteria { Name = "Computational biology", Tags = "computational biology,bioinformatics", Parent = computerSciences },
                new Criteria { Name = "Computational physics", Tags = "computational physics", Parent = computerSciences },
                new Criteria { Name = "Computational chemistry", Tags = "computational chemistry", Parent = computerSciences },
                new Criteria { Name = "Computational neuroscience", Tags = "computational neuroscience", Parent = computerSciences },
                new Criteria { Name = "Computer-aided engineering", Tags = "computer-aided engineering", Parent = computerSciences },
                new Criteria { Name = "Finite element analysis", Tags = "finite element analysis", Parent = computerSciences },
                new Criteria { Name = "Computational fluid dynamics", Tags = "computational fluid dynamics", Parent = computerSciences },
                new Criteria { Name = "Computational economics", Tags = "computational economics", Parent = computerSciences },
                new Criteria { Name = "Computational sociology", Tags = "computational sociology", Parent = computerSciences },
                new Criteria { Name = "Computational finance", Tags = "computational finance", Parent = computerSciences },
                new Criteria { Name = "The Digital Humanities", Tags = "the digital humanities,humanities computing", Parent = computerSciences },
                new Criteria { Name = "History of computer hardware", Tags = "history of computer hardware", Parent = computerSciences },
                new Criteria { Name = "History of computer science", Tags = "history of computer science", Parent = computerSciences },
                new Criteria { Name = "Humanistic informatics", Tags = "humanistic informatics", Parent = computerSciences },
                new Criteria { Name = "Community informatics", Tags = "community informatics", Parent = computerSciences }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                computerSciences.Children.Add(thirdLevelCriteria);
            }
        }
    }
}