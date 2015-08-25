using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathfinder.Generators.Background;

namespace Pathfinder.Generators.Tests
{
    public class UnitTestBase
    {
        protected bool TraitIsWithin(List<ITrait> traits, Type type)
        {
            foreach (ITrait characterTrait in traits)
            {
                if (type.Equals(characterTrait.GetType()))
                    return true;
            }

            return false;
        }

        protected bool FeatIsWithin(List<IStoryFeats> feats, Type type)
        {
            foreach (IStoryFeats characterFeat in feats)
            {
                if (type.Equals(characterFeat.GetType()))
                    return true;
            }

            return false;
        }

        protected void AssertTraits(List<ITrait> expected, List<ITrait> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, "Trait counts do not match");
            foreach (ITrait trait in expected)
            {
                Assert.IsTrue(TraitIsWithin(actual, trait.GetType()), "Trait does not match");
            }
        }

        protected void AssertStoryFeats(List<IStoryFeats> expected, List<IStoryFeats> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count, "Story Feat count does not match");

            foreach (IStoryFeats storyFeat in expected)
            {
                Assert.IsTrue(FeatIsWithin(actual, storyFeat.GetType()), "Expected Feat is not found");
            }
        }
    }
}
