using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IconLibrary.Caching
{
    /// <summary>
    /// A class that helps for locating and loading assembly resource files.
    /// </summary>
    internal class AssemblyResourceLink
    {
        private Assembly m_targetAssembly;
        private string m_resourcePath;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyResourceLink"/> class.
        /// </summary>
        /// <param name="targetAssembly">The target assembly.</param>
        /// <param name="resourcePath">The full path to the resource.</param>
        public AssemblyResourceLink(Assembly targetAssembly, string resourcePath)
        {
            if (string.IsNullOrEmpty(resourcePath)) { throw new ArgumentNullException(nameof(resourcePath)); }

            m_targetAssembly = targetAssembly;
            m_resourcePath = resourcePath;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder(100);
            if (m_targetAssembly != null) { resultBuilder.Append(m_targetAssembly.GetName().Name + ": "); }
            resultBuilder.Append(m_resourcePath);
            return resultBuilder.ToString();
        }

        /// <summary>
        /// Opens the resource for reading.
        /// </summary>
        public Stream OpenRead()
        {
            return m_targetAssembly.GetManifestResourceStream(this.ResourcePath);
        }

        /// <summary>
        /// Is this link valid?
        /// </summary>
        public bool IsValid()
        {
            var resourceInfo = m_targetAssembly.GetManifestResourceInfo(this.ResourcePath);
            return resourceInfo != null;
        }

        /// <summary>
        /// Gets the target assembly.
        /// </summary>
        public Assembly TargetAssembly
        {
            get { return m_targetAssembly; }
        }

        /// <summary>
        /// Gets the resource path.
        /// </summary>
        public string ResourcePath
        {
            get 
            {
                return m_resourcePath;
            }
        }
    }
}
