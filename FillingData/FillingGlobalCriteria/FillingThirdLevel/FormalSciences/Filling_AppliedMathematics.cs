using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_AppliedMathematics(ref SecondLevelCriteria appliedMathematics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Mathematical statistics", Tags = "mathematical statistics,statistics",  SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Econometrics", Tags = "econometrics,statistics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Actuarial science", Tags = "actuarial science,statistics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Demography", Tags = "demography,statistics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Approximation theory", Tags = "approximation theory", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Numerical analysis", Tags = "numerical analysis,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Mathematical optimization", Tags = "mathematical optimization,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Linear programming", Tags = "linear programming,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Dynamic programming", Tags = "dynamic programming,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Assignment problem", Tags = "assignment problem,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Decision analysis", Tags = "decision analysis,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Inventory theory", Tags = "inventory theory,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Scheduling", Tags = "scheduling,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Real options analysis", Tags = "real options analysis,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Systems analysis", Tags = "systems analysis,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Stochastic processes", Tags = "stochastic processes,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Optimal maintenance", Tags = "optimal maintenance,operations research", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Chaos theory", Tags = "chaos theory,dynamical systems", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Fractal geometry", Tags = "fractal geometry,dynamical systems", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Quantum mechanics", Tags = "quantum mechanics,mathematical physics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Quantum field theory", Tags = "quantum field theory,mathematical physics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Quantum gravity", Tags = "quantum gravity,mathematical physics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "String theory", Tags = "string theory,mathematical physics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Statistical mechanics", Tags = "statistical mechanics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Theory of computation", Tags = "theory of computation", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Computational complexity theory", Tags = "computational complexity theory", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Information theory", Tags = "information theory", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Cryptography", Tags = "cryptography", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Combinatorics", Tags = "combinatorics", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Coding theory", Tags = "coding theory", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Graph theory", Tags = "graph theory", SecondLevelCriteria = appliedMathematics },
                new ThirdLevelCriteria { Name = "Game theory", Tags = "game theory", SecondLevelCriteria = appliedMathematics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                appliedMathematics.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}