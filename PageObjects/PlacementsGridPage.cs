using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class PlacementsGridPage
    {
        public IWebDriver Driver;

        private static string CssSelectorBaseParentRowGrid = "div[id*='tabpane-PlacementsViewTab']>div[class*='taxonomy-grid']>div[class*='ReactTable']>div.rt-table>div.rt-tbody>div.rt-tr-group>";

        private static string CssSelectorBaseRowChildGrid = $"{CssSelectorBaseParentRowGrid}div:nth-child(2)>:nth-child(1)>div:nth-child(2)>div:nth-child(1)>div:nth-child(1)>";

        public Selector PlacementsViewTabContainer = new Selector("PlacementsViewTabContainer", "div.mainDiv >:nth-child(5)>div#creativesPlacementsTabs-tabpane-PlacementsViewTab>div.taxonomy-grid.mt-4", SelectorType.Css);

        public Selector RowsExpandableParent = new Selector("RowsExpandableParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>div.rt-td.rt-expandable", SelectorType.Css);

        public Selector LabelPackageDescListParent = new Selector("PackageDescListColumnParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(2)", SelectorType.Css);
        
        public Selector LabelPlacementNameListParent = new Selector("LabelPlacementNameListParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(3)", SelectorType.Css);
        
        public Selector LabelPlacementDescriptionListParent = new Selector("LabelPlacementDescriptionListParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(4)", SelectorType.Css);
        
        public Selector LabelSiteListParent = new Selector("LabelSiteListParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(5)", SelectorType.Css);

        public Selector LabelSizeListParent = new Selector("LabelSizeListParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(6)", SelectorType.Css);
        
        public Selector LabelNoOfCreativesListParent = new Selector("LabelNoOfCreativesListParent", $"{CssSelectorBaseParentRowGrid}:nth-child(1)>:nth-child(7)", SelectorType.Css);
        
        public Selector CheckBoxListSelecAllChildGrid = new Selector("LabelNoOfCreativesListParent", $"{CssSelectorBaseParentRowGrid}div:nth-child(2)>:nth-child(1)>div:nth-child(1)>div:nth-child(1)>:nth-child(1)>div:nth-child(1)>div:nth-child(1)>input", SelectorType.Css);

        public Selector CheckBoxListSingleChildGrid = new Selector("LabelNoOfCreativesListParent", $"{CssSelectorBaseParentRowGrid}div:nth-child(2)>:nth-child(1)>div:nth-child(1)>div:nth-child(1)>div:nth-child(1)>div:nth-child(1)>div:nth-child(1)>input", SelectorType.Css);

        public Selector LabelCreativeNameListChildGrid = new Selector("LabelCreativeNameListChildGrid", $"{CssSelectorBaseRowChildGrid}div:nth-child(2)", SelectorType.Css);

        public Selector LabelBaseURLListChildGrid = new Selector("LabelBaseURLListChildGrid", $"{CssSelectorBaseRowChildGrid}div:nth-child(3)", SelectorType.Css);
        
        public Selector LabelFinalURLListChildGrid = new Selector("LabelFinalURLListChildGrid", $"{CssSelectorBaseRowChildGrid}div:nth-child(4)", SelectorType.Css);
        
        public Selector LabelRotationListChildGrid = new Selector("LabelRotationListChildGrid", $"{CssSelectorBaseRowChildGrid}div:nth-child(5)", SelectorType.Css);

        public static Selector InputActualNumPageGrid = new Selector("RemoveAssigmentButton", "div[id$='-tabpane-PlacementsViewTab']>div>div>div.pagination-bottom>div>div+div>div.-numOfPages>div>input", SelectorType.Css);

        public static Selector LabelNumPagesGrid = new Selector("RemoveAssigmentButton", "div[id$='-tabpane-PlacementsViewTab']>div>div>div.pagination-bottom>div>div+div>div.-numOfPages>div>input", SelectorType.Css);

        public static Selector TooltipElement = new Selector("TooltipElement", "body>div#tooltipId", SelectorType.Css);
        
        public static Selector FinalUrlIconButton = new Selector("FinalUrlIconButton", "body>div#tooltipId", SelectorType.Css);

        public PlacementsGridPage(IWebDriver driver)
        {
            Driver = driver;
        }


        public WebElement SearchPlacementViewTabContainer()
        {
            WebElement we = new WebElement(PlacementsViewTabContainer,Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchRowsExpandableParent()
        {
            WebElement we = new WebElement(RowsExpandableParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelPackageDescListParent()
        {
            WebElement we = new WebElement(LabelPackageDescListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelPlacementNameListParent()
        {
            WebElement we = new WebElement(LabelPlacementNameListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelPlacementDescriptionListParent()
        {
            WebElement we = new WebElement(LabelPlacementDescriptionListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelSiteListParent()
        {
            WebElement we = new WebElement(LabelSiteListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelSizeListParent()
        {
            WebElement we = new WebElement(LabelSizeListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelNoOfCreativesListParent()
        {
            WebElement we = new WebElement(LabelNoOfCreativesListParent, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelCreativeNameListChildGrid()
        {
            WebElement we = new WebElement(LabelCreativeNameListChildGrid, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelBaseURLListChildGrid()
        {
            WebElement we = new WebElement(LabelBaseURLListChildGrid, Driver);
            we.SearchForThisElement();
            return we;
        }
        
        public WebElement SearchLabelFinalURLListChildGrid()
        {
            WebElement we = new WebElement(LabelFinalURLListChildGrid, Driver);
            we.SearchForThisElement();
            return we;
        }
        
        public WebElement SearchLabelRotationListChildGrid()
        {
            WebElement we = new WebElement(LabelRotationListChildGrid, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLabelNumPagesGrid()
        {
            WebElement we = new WebElement(LabelNumPagesGrid, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchTooltipElement()
        {
            WebElement we = new WebElement(TooltipElement, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SelectCheckBoxListSelecAllChildGrid(int indexRow)//in test
        {
            string selectString = $"{CssSelectorBaseParentRowGrid}div:nth-child(2)>:nth-child(1)>div:nth-child(1)>div:nth-child(1)>:nth-child(1)>div:nth-child(1)>div:nth-child(1)>input";
            Selector sel = new Selector("CssSelectorBaseParentRowGrid", selectString, SelectorType.Css);
            WebElement we = new WebElement(sel, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement EnterIntToNavigateInPaginationGrid(int page)
        {
            WebElement we = new WebElement(InputActualNumPageGrid, Driver);
            we = we.EnterTextInElement(we, page.ToString());
            return we;
        }

        public WebElement HoverInIconFinalUrlButton(int indexRow)
        {
            WebElement we = new WebElement(FinalUrlIconButton, Driver);
            WebPageDriver webpage = new WebPageDriver();
            we = we.HoverInElementByIndex(we, indexRow);
            return we;
        }

        public WebElement ClickOnRowExpadableByIndex(int indexRow)
        {
            WebElement we = new WebElement(RowsExpandableParent, Driver);
            WebPageDriver webpage = new WebPageDriver();
            we = we.ClickElementByIndex(we, indexRow);
            return we;
        }

    }
}
