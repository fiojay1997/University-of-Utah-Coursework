#pragma checksum "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\UsersPermissions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dfac2b23851549ae646c697915c6ceeeed37a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsersPermissions_Index), @"mvc.1.0.view", @"/Views/UsersPermissions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UsersPermissions/Index.cshtml", typeof(AspNetCore.Views_UsersPermissions_Index))]
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
#line 1 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
#line 2 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dfac2b23851549ae646c697915c6ceeeed37a3d", @"/Views/UsersPermissions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2f008bb030c689fdd92cf0ac6c09ff2675aa17", @"/Views/_ViewImports.cshtml")]
    public class Views_UsersPermissions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 450, true);
            WriteLiteral(@"<!--
  Author:    Aaron Templeton
  Date:      9/27/19
  Course:    CS 4540, University of Utah, School of Computing
  Copyright: CS 4540 and Aaron Templeton - This work may not be copied for use in Academic Coursework.

  I, Aaron Templeton, certify that I wrote this code from scratch and did not copy it in part or whole from
  another source.  Any references used in the completion of the assignment are cited in my README file.


-->
");
            EndContext();
            BeginContext(466, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\aaron\Documents\CS 4540\CS4540_Assignment_2\Assignment2\Views\UsersPermissions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(558, 589, true);
            WriteLiteral(@"
<h1>Users and Permissions</h1>
<hr />
<br />
<div class=""container"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>User</th>
                <th>Admin</th>
                <th>Chair</th>
                <th>Instructor</th>
            </tr>
        </thead>
        <tbody>  
            <tr>
                <td colspan=""4"">
                    <div class=""spinner-grow"" role=""status"">
                        <span  class=""sr-only"">Loading...</span>
                    </div>
                </td>
            </tr>

");
            EndContext();
            BeginContext(3174, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3235, 4479, true);
                WriteLiteral(@"
<script text=""text/javascript"">

    $(document).ready(function () {

        loadTable();

        $(document).on('click', 'input',function () {
            var id = $(this).attr('id').split(""-"");
            ajaxChangeRole(id[0], id[1], $(this));
        });

    });

    async function ajaxChangeRole(user, num, s) {
        const { value: accept } = await Swal.fire({
            title: 'Change Role?',
            text: 'Are you sure you want to change roles?',
            type: 'question',
            confirmButtonText: ""Yes"",
            showCancelButton: true,
            cancelButtonText: 'Cancel'
        });
        if (accept) {
            var userData = { User: user, Num: num };
            $.ajax({
                url: ""UsersPermissions/changeRole"",
                method: ""POST"",
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                data: JSON.stringify(userData),
            }).done(function (result) {
  ");
                WriteLiteral(@"              JSON.stringify(result);
                if (result.success === false) {
                    Swal.fire({
                        title: ""Denied!"",
                        text: 'Cannot remove only Admin',
                        type: 'error',
                        confirmButtonText: 'Ok'
                    })
                } else {
                    Swal.fire({
                        title: ""Success!"",
                        text: 'Successfully updated role!',
                        type: 'success',
                        confirmButtonText: 'Ok'
                    });
                }
                loadTable();
            }).fail(function (jqXHR, textStatus, error) {
                Swal.fire({
                    title: 'Error',
                    text: 'There was an error. Try again or contact administrator',
                    type: 'error',
                    confirmButtonText: 'Ok'
                })
            })
        }
        else {
     ");
                WriteLiteral(@"       loadTable();
        }
        
    }

    function loadTable() {
        $.ajax({
            url: 'UsersPermissions/getUsersRoles',
            method: ""GET""
        }).done(function (res) {
            var html="""";
            $.each(res.data, function (key, val) {
                 html += ""<tr><td>"" + val.name + ""</td>"";
                for (var i = 0; i < 3; i++) {
                    if ($.inArray(""Admin"", val.roles)!=-1 && i == 0) {
                        html += '<td> <div class=""text-center custom-control custom-switch"">';
                        html += '<input type=""checkbox"" class=""custom-control-input"" id=""' + val.name+'-'+ i + '"" checked>';
                        html += '<label class=""custom-control-label"" for=""' + val.name+'-'+ i + '"" ></label>';
                        html+=  '</div></td>';
                    }
                    else if (i === 1 && $.inArray(""Chair"", val.roles)!=-1) {
                        html += '<td> <div class=""text-center custom-contro");
                WriteLiteral(@"l custom-switch"">';
                        html += '<input type=""checkbox"" class=""custom-control-input"" id=""' + val.name + '-' + i + '"" checked>';
                        html += '<label class=""custom-control-label"" for=""' + val.name + '-' + i + '"" ></label>';
                        html += '</div></td>';
                    }
                    else if (i === 2 && $.inArray(""Instructor"", val.roles)!=-1) {
                        html += '<td> <div class=""text-center custom-control custom-switch"">';
                        html += '<input type=""checkbox"" class=""custom-control-input"" id=""' + val.name + '-' + i + '"" checked>';
                        html += '<label class=""custom-control-label"" for=""' + val.name + '-' + i + '"" ></label>';
                        html += '</div></td>';
                    }
                    else {
                        html += '<td> <div class=""text-center custom-control custom-switch"">';
                        html += '<input type=""checkbox"" class=""custom-");
                WriteLiteral(@"control-input"" id=""' + val.name + '-' + i + '"">';
                        html += '<label class=""custom-control-label"" for=""' + val.name + '-' + i + '"" ></label>';
                        html += '</div></td>';
                    }
                }
                html += ""</tr>"";
            });
            $(""tbody"").html(html);
            })
        }

</script>
");
                EndContext();
            }
            );
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
