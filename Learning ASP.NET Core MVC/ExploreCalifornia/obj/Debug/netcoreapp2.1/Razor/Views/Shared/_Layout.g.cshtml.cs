#pragma checksum "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0004becb1365c3af64672535c902effe66d784d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0004becb1365c3af64672535c902effe66d784d", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a26c5247d7aa4e5b821829b5f226de16", async() => {
                BeginContext(41, 592, true);
                WriteLiteral(@"
<meta charset=""utf-8"">
<title>Welcome to Explore California</title>
<meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
<meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
<!--make sure mobile devices display the page at the proper scale	-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<!--[if lt IE 9]>
<script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
<![endif]-->
<link href=""/css/main.css"" rel=""stylesheet"" type=""text/css"" media=""screen, projection"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(642, 4654, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc109461b62543ac97eeec5f87b2fae4", async() => {
                BeginContext(672, 1650, true);
                WriteLiteral(@"
<div id=""wrapper"">
  <header id=""mainHeader""> <a href=""/"" title=""home"" class=""logo"">
   <!-- I need this div because IE is an affront to mankind-->
    <div>
    <h1>Explore California</h1>
    </div>
    </a>
    <nav id=""siteNav"">
      <h1>Where do you want to go?</h1>
      <ul>
       <li><a href=""/tours.htm"" title=""Our tours"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
          <ul>
            <li><a href=""/tours.htm"" title=""Our tours"">All Tours</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Activity</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Region</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tour Finder</a></li>
          </ul>
        </li>
        <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
        <li><a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your t");
                WriteLiteral(@"rip</span></a>
          <ul>
            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
            <li><a href=""resources/additional_resources.htm"" title=""additional resources"">Tour Information</a></li>
            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
          </ul>
        </li>
        <li><a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
          <ul>
            <li><a href=""explorers/join.htm"" title=""join our community"">Join the Explorers</a></li>
            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2322, "\"", 2357, 1);
#line 45 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2329, Url.Action("Index", "Blog"), 2329, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2358, 47, true);
                WriteLiteral(" title=\"read our blog\">Read Our Blog</a></li>\r\n");
                EndContext();
                BeginContext(2522, 564, true);
                WriteLiteral(@"            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
          </ul>
        </li>
        <li><a href=""contact.htm"" title=""contact us"" class=""last"">Contact <br /><span class=""tagline"">we're listening</span></a>
          <ul>
            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
          </ul>
        </li>
      </ul>
    </nav>
  </header>
  <section id=""actionCall"">
");
                EndContext();
#line 60 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
       if (IsSectionDefined("actionCall"))
      {
          

#line default
#line hidden
                BeginContext(3150, 34, false);
#line 62 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
     Write(RenderSection("actionCall", false));

#line default
#line hidden
                EndContext();
#line 62 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
                                             
      }
      else
      {

#line default
#line hidden
                BeginContext(3216, 48, true);
                WriteLiteral("          <h1>Explore our world your way!</h1>\r\n");
                EndContext();
#line 67 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
      }

#line default
#line hidden
                BeginContext(3273, 87, true);
                WriteLiteral("  </section>\r\n  <div id=\"contentWrapper\">\r\n      <section id=\"mainContent\">\r\n          ");
                EndContext();
                BeginContext(3361, 12, false);
#line 71 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
     Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3373, 57, true);
                WriteLiteral("\r\n      </section>\r\n      <aside id=\"secondaryContent\">\r\n");
                EndContext();
#line 74 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
           if (IsSectionDefined("secondaryContent"))
          {
              

#line default
#line hidden
                BeginContext(3512, 40, false);
#line 76 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
         Write(RenderSection("secondaryContent", false));

#line default
#line hidden
                EndContext();
#line 76 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
                                                       
          }
          else
          {

#line default
#line hidden
                BeginContext(3596, 69, true);
                WriteLiteral("              <div id=\"specials\" class=\"callOut\">\r\n                  ");
                EndContext();
                BeginContext(3666, 94, false);
#line 81 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
             Write(await (Component.InvokeAsync<ExploreCalifornia.ViewComponents.MonthlySpecialsViewComponent>()));

#line default
#line hidden
                EndContext();
                BeginContext(3760, 226, true);
                WriteLiteral("\r\n              </div>\r\n              <div id=\"trivia\" class=\"callOut\">\r\n                  <h1>Did You Know?</h1>\r\n                  <p>California produces over 17 million gallons of wine each year!</p>\r\n              </div>\r\n");
                EndContext();
#line 87 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
          }

#line default
#line hidden
                BeginContext(3999, 992, true);
                WriteLiteral(@"      </aside>
  </div>
  <footer id=""pageFooter"">
  <section id=""quickLinks"">
  <h1>Quick Nav</h1>
    <ul id=""quickNav"">
      <li><a href=""/"" title=""Our home page"">Home</a></li>
      <li><a href=""/tours.htm"" title=""Explore our tours"">Tours</a></li>
      <li><a href=""mission.htm"" title=""What we think"">Mission</a></li>
      <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
      <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
      <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
    </ul>
  </section>
  <section id=""footerResources"">
  <h1>Resources</h1>
    <ul id=""quickNav"">
      <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
      <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
      <li><a href=""resources/legal.htm"" title=""The fine print"">Legal</a></li><li><a href=""login.htm"">Login</a></li>
    </ul>
      <p>
          Copyright Adam Ayd ");
                EndContext();
                BeginContext(4992, 17, false);
#line 110 "C:\Users\adama\source\repos\ASP.NET\Learning ASP.NET Core MVC\ExploreCalifornia\Views\Shared\_Layout.cshtml"
                        Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(5009, 280, true);
                WriteLiteral(@"
      </p>
  </section>
  <section id=""companyInfo"">
  <h1>Contact</h1>
  <h2>Explore California</h2>
      <p>5605 Nota Street<br />
        Ventura, CA 93003</p>
      <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>
  </section>
  </footer>
</div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5296, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
