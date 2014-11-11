using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_AppliedMathematics(ref Criteria appliedMathematics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Mathematical statistics", Tags = "mathematical statistics,statistics",  Parent = appliedMathematics },
                new Criteria { Name = "Econometrics", Tags = "econometrics,statistics", Parent = appliedMathematics },
                new Criteria { Name = "Actuarial science", Tags = "actuarial science,statistics", Parent = appliedMathematics },
                new Criteria { Name = "Demography", Tags = "demography,statistics", Parent = appliedMathematics },
                new Criteria { Name = "Approximation theory", Tags = "approximation theory", Parent = appliedMathematics },
                new Criteria { Name = "Numerical analysis", Tags = "numerical analysis,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Mathematical optimization", Tags = "mathematical optimization,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Linear programming", Tags = "linear programming,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Dynamic programming", Tags = "dynamic programming,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Assignment problem", Tags = "assignment problem,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Decision analysis", Tags = "decision analysis,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Inventory theory", Tags = "inventory theory,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Scheduling", Tags = "scheduling,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Real options analysis", Tags = "real options analysis,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Systems analysis", Tags = "systems analysis,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Stochastic processes", Tags = "stochastic processes,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Optimal maintenance", Tags = "optimal maintenance,operations research", Parent = appliedMathematics },
                new Criteria { Name = "Chaos theory", Tags = "chaos theory,dynamical systems", Parent = appliedMathematics },
                new Criteria { Name = "Fractal geometry", Tags = "fractal geometry,dynamical systems", Parent = appliedMathematics },
                new Criteria { Name = "Quantum mechanics", Tags = "quantum mechanics,mathematical physics", Parent = appliedMathematics },
                new Criteria { Name = "Quantum field theory", Tags = "quantum field theory,mathematical physics", Parent = appliedMathematics },
                new Criteria { Name = "Quantum gravity", Tags = "quantum gravity,mathematical physics", Parent = appliedMathematics },
                new Criteria { Name = "String theory", Tags = "string theory,mathematical physics", Parent = appliedMathematics },
                new Criteria { Name = "Statistical mechanics", Tags = "statistical mechanics", Parent = appliedMathematics },
                new Criteria { Name = "Theory of computation", Tags = "theory of computation", Parent = appliedMathematics },
                new Criteria { Name = "Computational complexity theory", Tags = "computational complexity theory", Parent = appliedMathematics },
                new Criteria { Name = "Information theory", Tags = "information theory", Parent = appliedMathematics },
                new Criteria { Name = "Cryptography", Tags = "cryptography", Parent = appliedMathematics },
                new Criteria { Name = "Combinatorics", Tags = "combinatorics", Parent = appliedMathematics },
                new Criteria { Name = "Coding theory", Tags = "coding theory", Parent = appliedMathematics },
                new Criteria { Name = "Graph theory", Tags = "graph theory", Parent = appliedMathematics },
                new Criteria { Name = "Game theory", Tags = "game theory", Parent = appliedMathematics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                appliedMathematics.Children.Add(thirdLevelCriteria);
            }
        }
    }
}