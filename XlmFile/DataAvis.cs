using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace TPLOCAL
{
    public class ListReviews
    {
        /// <summary>
        /// Function to retrieve the list of reviews contained in an XML file
        /// </summary>
        /// <param name="file">file path</param>
        public List<Reviews> GetAvis(string file)
        {
            // Instantiate the list as empty 
            List<Reviews> listreviews = new List<Reviews>();
            // Creating an XMLDocument object  to retrieve data from the physical file
            XmlDocument xmlDoc = new XmlDocument();
            // Reading the file from a StreamReader object
            StreamReader streamDoc = new StreamReader(file);
            string dataXml = streamDoc.ReadToEnd();
            // Loading Data into the XmlDocument
            xmlDoc.LoadXml(dataXml);

            // Retrieving the nodes to  pass them as a Notice object and then adding them to the 'ListNotices' list
            // We loop on each node of  type XmlNode having for path "root/row" (cf structure of the xml file)
            // The SelectNodes method  retrieves all nodes with the specified path
            foreach (XmlNode node in xmlDoc.SelectNodes("root/row"))
            {
                // Retrieving data in child nodes
                string name = node["Name"].InnerText;
                string firstname = node["Firstname"].InnerText;
                string avisdonne = node["Avis"].InnerText;

                // Creating the Notice Object to Add to the Results List
                Reviews avis = new Reviews
                {
                    Name = name,
                    Prenom = firstname,
                    AvisDonne = avisdonne
                };
                listreviews.Add(avis);
            }

            // The list formed by the treatment is returned to the calling method
            return listreviews;
        }
    }

    // . :Info:.
    // This class can be checked out in a new C# page but as part of the TP it can be left in the same page.
    // It is necessary to avoid as much as possible to have the same page with several classes inside.
    // Even if it works, it can complicate code readability and ultimately maintenance.
    /// <summary>
    /// Object grouping data related to reviews.
    /// \n Can be modified
    /// </summary>
    public class Reviews
    {
        /// <summary>
        /// Surname
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Forename
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Notice given (Possible values : O or N)
        /// </summary>
        public string AvisDonne { get; set; }
    }
}