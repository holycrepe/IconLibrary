#if DEBUG
using IconLibrary.IconConverter.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IconLibrary.IconConverter.Tests
{
    public class IconFileContainerTests
    {
        public const string TEST_CATEGORY = "IconLibrary FileContainer";

        [Fact]
        [Trait("Category", TEST_CATEGORY)]
        public void AddNewItem()
        {
            bool collectionChangedFired = false;

            IconFileContainer fileContainer = new IconFileContainer();
            fileContainer.IconCollectionChanged += (sender, eArgs) =>
            {
                collectionChangedFired = true;
            };

            Assert.True(collectionChangedFired);
        }
    }
}
#endif