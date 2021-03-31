using System;
using DeliveryHeroAutomation.Framework.Model.Base;

namespace DeliveryHeroAutomation.Framework.Services
{
    public class PageManager
    {

        private static readonly Lazy<PageManager> _instance = new Lazy<PageManager>(() => new PageManager());

        public static PageManager Instance => _instance.Value;


        public BasePage CurrentPage;

        private PageManager()
        {

        }
    }
}