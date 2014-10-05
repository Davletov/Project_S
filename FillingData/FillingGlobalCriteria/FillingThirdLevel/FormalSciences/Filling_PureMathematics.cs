using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PureMathematics(ref SecondLevelCriteria pureMathematics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<ThirdLevelCriteria>
            {
                new ThirdLevelCriteria { Name = "Group theory", Tags = "group theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Group representation", Tags = "group representation,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Ring theory", Tags = "ring theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Commutative algebra", Tags = "commutative algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Noncommutative algebra", Tags = "noncommutative algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Field theory", Tags = "field theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Linear algebra", Tags = "linear algebra,vector space,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Multilinear algebra", Tags = "multilinear algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Lie algebra", Tags = "lie algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Associative algebra", Tags = "associative algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Non-associative algebra", Tags = "non-associative algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Universal algebra", Tags = "universal algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Homological algebra", Tags = "homological algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Differential algebra", Tags = "differential algebra,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Lattice theory", Tags = "lattice theory,order theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Representation theory", Tags = "representation theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "K-theory", Tags = "k-theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Category theory", Tags = "category theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Topos theory", Tags = "topos theory,algebra", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Real analysis", Tags = "real analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Calculus", Tags = "calculus,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Complex analysis", Tags = "complex analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Functional analysis", Tags = "functional analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Operator theory", Tags = "operator theory,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Non-standard analysis", Tags = "non-standard analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Harmonic analysis", Tags = "harmonic analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Fourier analysis", Tags = "fourier analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "p-adic analysis", Tags = "p-adic analysis,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Ordinary differential equations", Tags = "ordinary differential equations,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Partial differential equations", Tags = "partial differential equations,analysis", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Measure theory", Tags = "measure theory,probability theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Integral geometry", Tags = "integral geometry,probability theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Ergodic theory", Tags = "ergodic theory,probability theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Stochastic process", Tags = "stochastic process,probability theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "General topology", Tags = "general topology,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Algebraic topology", Tags = "algebraic topology,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Geometric topology", Tags = "geometric topology,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Differential topology", Tags = "differential topology,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Projective geometry", Tags = "projective geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Affine geometry", Tags = "affine geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Non-Euclidean geometry", Tags = "non-euclidean geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Convex geometry", Tags = "convex geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Discrete geometry", Tags = "discrete geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Integral geometry", Tags = "integral geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Noncommutative geometry", Tags = "noncommutative geometry,geometry,topology", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Analytic number theory", Tags = "analytic number theory,number theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Algebraic number theory", Tags = "algebraic number theory,number theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Geometric number theory", Tags = "geometric number theory,number theory", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Set theory", Tags = "set theory,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Proof theory", Tags = "proof theory,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Model theory", Tags = "Model theory,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Recursion theory", Tags = "recursion theory,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Modal logic", Tags = "modal logic,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics },
                new ThirdLevelCriteria { Name = "Intuitionistic logic", Tags = "intuitionistic logic,logic,foundations of mathematics", SecondLevelCriteria = pureMathematics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList)
            {
                uow.Repository<ThirdLevelCriteria>().Add(thirdLevelCriteria);
                pureMathematics.ThirdLevelCriteria.Add(thirdLevelCriteria);
            }
        }
    }
}