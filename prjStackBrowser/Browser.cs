using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStackBrowser
{
    class Browser
    {
        private Stack<string> history;
        private string currentPage;

        public Browser(int historySize)
        {
            history = new Stack<string>(historySize);
        }
        public string CurrentPage => currentPage;

        public void visitPage(string url)
        {
            if (currentPage != null)
            {
                history.Push(currentPage);
            }
            currentPage = url;
        }
        public string GoBAck()
        {
            if (!history.IsEmpty())
            {
                currentPage = history.Pop();
            }
            else
            {
                currentPage = "No more pages in History";
            }
            return currentPage;
        }

        public string[] GetHistroy()
        {
            return history.ToArray();
        }
    }
}
