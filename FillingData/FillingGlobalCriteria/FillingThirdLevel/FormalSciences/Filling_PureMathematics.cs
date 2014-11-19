using System.Linq;
using Web.DataAccess.Repository;

namespace FiilingData.FillingGlobalCriteria.FillingThirdLevel
{
    using System.Collections.Generic;
    using Web.Models.Criteria;    

    public partial class FillingThirdLevelCriteria
    {
        public static void Filling_PureMathematics(ref Criteria pureMathematics, UnitOfWork uow)
        {
            var tmpThirdCritList = new List<Criteria>
            {
                new Criteria { Name = "Group theory", Tags = "group theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Group representation", Tags = "group representation,algebra", Parent = pureMathematics },
                new Criteria { Name = "Ring theory", Tags = "ring theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Commutative algebra", Tags = "commutative algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Noncommutative algebra", Tags = "noncommutative algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Field theory", Tags = "field theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Linear algebra", Tags = "linear algebra,vector space,algebra", Parent = pureMathematics },
                new Criteria { Name = "Multilinear algebra", Tags = "multilinear algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Lie algebra", Tags = "lie algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Associative algebra", Tags = "associative algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Non-associative algebra", Tags = "non-associative algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Universal algebra", Tags = "universal algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Homological algebra", Tags = "homological algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Differential algebra", Tags = "differential algebra,algebra", Parent = pureMathematics },
                new Criteria { Name = "Lattice theory", Tags = "lattice theory,order theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Representation theory", Tags = "representation theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "K-theory", Tags = "k-theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Category theory", Tags = "category theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Topos theory", Tags = "topos theory,algebra", Parent = pureMathematics },
                new Criteria { Name = "Real analysis", Tags = "real analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Calculus", Tags = "calculus,analysis", Parent = pureMathematics },
                new Criteria { Name = "Complex analysis", Tags = "complex analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Functional analysis", Tags = "functional analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Operator theory", Tags = "operator theory,analysis", Parent = pureMathematics },
                new Criteria { Name = "Non-standard analysis", Tags = "non-standard analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Harmonic analysis", Tags = "harmonic analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Fourier analysis", Tags = "fourier analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "p-adic analysis", Tags = "p-adic analysis,analysis", Parent = pureMathematics },
                new Criteria { Name = "Ordinary differential equations", Tags = "ordinary differential equations,analysis", Parent = pureMathematics },
                new Criteria { Name = "Partial differential equations", Tags = "partial differential equations,analysis", Parent = pureMathematics },
                new Criteria { Name = "Measure theory", Tags = "measure theory,probability theory", Parent = pureMathematics },
                new Criteria { Name = "Integral geometry", Tags = "integral geometry,probability theory", Parent = pureMathematics },
                new Criteria { Name = "Ergodic theory", Tags = "ergodic theory,probability theory", Parent = pureMathematics },
                new Criteria { Name = "Stochastic process", Tags = "stochastic process,probability theory", Parent = pureMathematics },
                new Criteria { Name = "General topology", Tags = "general topology,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Algebraic topology", Tags = "algebraic topology,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Geometric topology", Tags = "geometric topology,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Differential topology", Tags = "differential topology,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Projective geometry", Tags = "projective geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Affine geometry", Tags = "affine geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Non-Euclidean geometry", Tags = "non-euclidean geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Convex geometry", Tags = "convex geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Discrete geometry", Tags = "discrete geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Integral geometry", Tags = "integral geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Noncommutative geometry", Tags = "noncommutative geometry,geometry,topology", Parent = pureMathematics },
                new Criteria { Name = "Analytic number theory", Tags = "analytic number theory,number theory", Parent = pureMathematics },
                new Criteria { Name = "Algebraic number theory", Tags = "algebraic number theory,number theory", Parent = pureMathematics },
                new Criteria { Name = "Geometric number theory", Tags = "geometric number theory,number theory", Parent = pureMathematics },
                new Criteria { Name = "Set theory", Tags = "set theory,logic,foundations of mathematics", Parent = pureMathematics },
                new Criteria { Name = "Proof theory", Tags = "proof theory,logic,foundations of mathematics", Parent = pureMathematics },
                new Criteria { Name = "Model theory", Tags = "Model theory,logic,foundations of mathematics", Parent = pureMathematics },
                new Criteria { Name = "Recursion theory", Tags = "recursion theory,logic,foundations of mathematics", Parent = pureMathematics },
                new Criteria { Name = "Modal logic", Tags = "modal logic,logic,foundations of mathematics", Parent = pureMathematics },
                new Criteria { Name = "Intuitionistic logic", Tags = "intuitionistic logic,logic,foundations of mathematics", Parent = pureMathematics }
            };

            foreach (var thirdLevelCriteria in tmpThirdCritList.OrderBy(x => x.Name))
            {
                uow.Repository<Criteria>().Add(thirdLevelCriteria);
                pureMathematics.Children.Add(thirdLevelCriteria);
            }
        }
    }
}