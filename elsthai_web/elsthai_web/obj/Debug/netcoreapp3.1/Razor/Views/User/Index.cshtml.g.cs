#pragma checksum "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0341500883162d9d207720f31b1be4f73a49da83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\_ViewImports.cshtml"
using elsthai_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\_ViewImports.cshtml"
using elsthai_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0341500883162d9d207720f31b1be4f73a49da83", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea82add8a066f03ffc524d8735954b1942e1da89", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", new global::Microsoft.AspNetCore.Html.HtmlString("black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0341500883162d9d207720f31b1be4f73a49da833550", async() => {
                WriteLiteral(@"
    <style>
        * {
            font-family: 'Bai Jamjuree', sans-serif;
        }

        #tbresult td, #tbresult th {
            border: 1px solid #ddd;
            padding: 8px;
        }

        #tbresult tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #tbresult tr:hover {
            background-color: #ddd;
        }

        #tbresult th {
            width: 90px;
            padding-top: 8px;
            padding-bottom: 8px;
            text-align: center;
            background-color: #78e08f;
            color: black;
        }
        h3 {
            margin: 20px;
        }
    </style>
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0341500883162d9d207720f31b1be4f73a49da835188", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h3 align=\"center\">ข้อมูลผู้ใช้งาน</h3>\r\n        <p>\r\n            ");
#nullable restore
#line 39 "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\User\Index.cshtml"
       Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n\r\n        <table");
                BeginWriteAttribute("class", " class=\"", 896, "\"", 904, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""tbresult"" width=""90%"" align=""center"">
            <tr>
                <th>ชื่อ-นามสกุล</th>
                <th>อีเมล</th>
                <th>เบอร์โทรศัพท์</th>
                <th>จัดการ</th>
            </tr>

        </table>
    </div>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-app.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-auth.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-firestore.js""></script>
    <script>
        // For Firebase JS SDK v7.20.0 and later, measurementId is optional
        const firebaseConfig = {
            apiKey: ""AIzaSyDAmC5P4Yz1AA1fsZs_vkFmOvkkRoU2u7Y"",
            authDomain: ""kcs-database.firebaseapp.com"",
            databaseURL: ""https://kcs-database.firebaseio.com"",
            projectId: ""kcs-database"",
            storageBucket: ""kcs-database.appspot.com"",
            messagingSenderId: ""942140079361"",
            appId: ""1:942140079361:web:d06709c7");
                WriteLiteral(@"bafe9440c2ef00"",
            measurementId: ""G-63XXEQFVS1""
        };


        firebase.initializeApp(firebaseConfig);
        let firestore = firebase.firestore()

        ////
        firebase.firestore().collection(""userProfile"").get().then((snapshot) => {
            snapshot.forEach(doc => {
                console.log(doc.data());
                showData(doc);
            })
        });

        const table = document.querySelector('#tbresult');

        ///
        function showData(doc) {
            console.log(doc.data());
            var row = table.insertRow(-1);
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            var cell4 = row.insertCell(3);

            cell1.innerHTML = doc.data().name;
            cell2.innerHTML = doc.data().email;
            cell3.innerHTML = doc.data().phone;
            cell4.innerHTML = ""<a href='/user/edit?email="" + doc.data().email + ""&name="" + doc");
                WriteLiteral(@".data().name + ""&phone="" + doc.data().phone + ""&pass="" + doc.data().pass + ""'>แก้ไข</a></a> <a  href='/user/delete?email="" + doc.data().email + ""&name="" + doc.data().name + ""&phone="" + doc.data().phone + ""&pass="" + doc.data().pass +""'>ลบ</a>"";
        }
        
        document.getElementById('BtnCreate').onclick = function () {
            Create();
        }
        
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
