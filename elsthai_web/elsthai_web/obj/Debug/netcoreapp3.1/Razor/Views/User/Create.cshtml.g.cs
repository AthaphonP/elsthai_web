#pragma checksum "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df6dd49eb99215662933fdd1a5528338bdbafdb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6dd49eb99215662933fdd1a5528338bdbafdb0", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea82add8a066f03ffc524d8735954b1942e1da89", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<elsthai_web.Models.User>
    {
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
#nullable restore
#line 2 "C:\Users\early\Downloads\elsthai_web\elsthai_web\Views\User\Create.cshtml"
  
    ViewBag.Title = "Create";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df6dd49eb99215662933fdd1a5528338bdbafdb03433", async() => {
                WriteLiteral(@"
    <style>
        * {
            box-sizing: border-box;
            font-family: 'Bai Jamjuree', sans-serif;
        }

        input[type=text], select, textarea {
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            resize: vertical;
        }

        label {
            padding: 12px 12px 12px 0;
            display: inline-block;
        }

        input[type=submit] {
            width: 50%;
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

            input[type=submit]:hover {
                background-color: #45a049;
            }

        .container {
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 20px;
        }

        .col-25 {
            float: left;
    ");
                WriteLiteral(@"        width: 15%;
            margin-top: 6px;
        }

        .col-75 {
            float: left;
            width: 75%;
            margin-top: 6px;
        }

        .col-80 {
            float: left;
            width: 10%;
            margin-top: 6px;
        }

        .col-85 {
            float: left;
            width: 30%;
            margin-top: 6px;
        }
        /* Clear floats after the columns */
        .row:after {
            content: """";
            display: table;
            clear: both;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df6dd49eb99215662933fdd1a5528338bdbafdb06033", async() => {
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css2?family=Bai+Jamjuree&display=swap"" rel=""stylesheet"">
    <br>
    <h2>เพิ่ม ผู้ใช้งาน</h2>

    <div class=""container"">
            <div class=""row"">

            </div>
            <div class=""row"">
                <div class=""col-25"">
                    <label for=""fname"">ชื่อ-นามสกุล</label>
                </div>
                <div class=""col-80"">
                    <input type=""text"" id=""name"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 2199, "\"", 2207, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""ชื่อ-นามสกุล"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-25"">
                    <label for=""fname"">เบอร์โทร</label>
                </div>
                <div class=""col-80"">
                    <input type=""text"" id=""phone"" name=""phone""");
                BeginWriteAttribute("value", " value=\"", 2532, "\"", 2540, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""08XXXXXXXX"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-25"">
                    <label for=""subject"">อีเมล</label>
                </div>
                <div class=""col-75"">

                    <input type=""text"" id=""email"" name=""email""");
                BeginWriteAttribute("value", " value=\"", 2864, "\"", 2872, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""test@gmail.com"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-25"">
                    <label for=""subject"">รหัสผ่าน</label>
                </div>
                <div class=""col-75"">
                    <input type=""password"" id=""password_user"" name=""password_user""");
                BeginWriteAttribute("value", " value=\"", 3221, "\"", 3229, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""**********"">
                    <input type=""hidden"" id=""isdelete"" name=""isdelete"" value=""0"">
                </div>
            </div>
            <div class=""form-group row"">

                <div class=""col-sm-10"">
                    <button id=""BtnCreate"">Create</button>
                </div>
            </div>
 
    </div>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-app.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-auth.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/8.2.6/firebase-firestore.js""></script>
    <script>
        //ประกาศตัวแปรรับค่า
       
        
        // For Firebase JS SDK v7.20.0 and later, measurementId is optional
        const firebaseConfig = {
            apiKey: ""AIzaSyDAmC5P4Yz1AA1fsZs_vkFmOvkkRoU2u7Y"",
            authDomain: ""kcs-database.firebaseapp.com"",
            databaseURL: ""https://kcs-database.firebaseio.com"",
            projectId: ""kcs-database"",
");
                WriteLiteral(@"            storageBucket: ""kcs-database.appspot.com"",
            messagingSenderId: ""942140079361"",
            appId: ""1:942140079361:web:d06709c7bafe9440c2ef00"",
            measurementId: ""G-63XXEQFVS1""
        };


        firebase.initializeApp(firebaseConfig);
        let firestore = firebase.firestore()
        let idemail = email;
        ////
        function Create() {
            var name = document.getElementById('name').value;
            var phone = document.getElementById('phone').value;
            var email = document.getElementById('email').value;
            var password_user = document.getElementById('password_user').value;
            console.log(""1  "");
            console.log(name, phone, email, password_user);


            firestore.collection(""userProfile"").doc(email).set({ 
                birth: ""000"",
                email: email,
                name: name,
                pass: password_user,
                phone: phone
            }).then(function (");
                WriteLiteral(@"doc) {

                console.info(doc.email)
                alert(""Saved successfully"");
                window.location.href = ""/user/index"";
            }).catch(function (error) {
                alert(""Saved successfully"");
                window.location.href = ""/user/index"";

                console.error(error)
                alert(""Saved successfully"");
                window.location.href = ""/user/index"";
            });
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<elsthai_web.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
