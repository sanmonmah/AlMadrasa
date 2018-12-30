#pragma checksum "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7008cf541032f6c26e9741a7a3d726cf2e64f66"
// <auto-generated/>
#pragma warning disable 1591
namespace AlMadrasa.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using AlMadrasa.Client;
    using AlMadrasa.Client.Shared;
    using AlMadrasa.Client.Pages;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/studentdata")]
    public class StudentData : StudentDataModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, @"<head>
    <style>
    .my-form-group
    {
        margin: 2px 2px;
    }
    .my-control-label
    {
       display: inline-block;
        margin-bottom: .1rem;
        width: 30%;
          
    }
    .my-form-control
    {
        width: 50%;
        padding: 5px 10px;
        margin: 8px 5px;
        display: inline-block;
        border: 1px solid #ccc;
        border-radius: 4px;
        box-sizing: border-box;        
    }
    .my-btn{
        background:#ff0000
    }
    </style>
</head>
");
            builder.AddMarkupContent(1, "<h1>Student Data</h1>\n");
            builder.AddMarkupContent(2, "<h3>Iqraa registered student</h3>\n<br>\n");
            builder.OpenElement(3, "div");
            builder.AddContent(4, "\n    ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "style", "float:left");
            builder.AddContent(7, "\n        ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "class", "btn btn-primary");
            builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(AddStudent));
            builder.AddContent(11, "Add Student");
            builder.CloseElement();
            builder.AddContent(12, "\n        ");
            builder.OpenElement(13, "button");
            builder.AddAttribute(14, "class", "my-btn");
            builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(SaveDB2Json));
            builder.AddContent(16, "Save DB 2 Json");
            builder.CloseElement();
            builder.AddContent(17, "\n    ");
            builder.CloseElement();
            builder.AddContent(18, "\n\n");
            builder.CloseElement();
            builder.AddMarkupContent(19, "\n<br>\n\n");
#line 44 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
 if (studList == null)
{

#line default
#line hidden
            builder.AddContent(20, "    ");
            builder.AddMarkupContent(21, "<p><em>Loading...</em></p>\n");
#line 47 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
}
else
{

#line default
#line hidden
            builder.AddContent(22, "    ");
            builder.OpenElement(23, "table");
            builder.AddAttribute(24, "class", "table");
            builder.AddContent(25, "\n        ");
            builder.AddMarkupContent(26, @"<thead>
            <tr>
            <th>Name             </th>    
            <th>Surname          </th>    
            <th>Branch           </th>    
            <th>Birthday         </th>    
            <th>EntryDate        </th>    
            <th>LeavingDate      </th>    
            <th>arClass          </th>    
            <th>qClass           </th>    
            <th>PhoneNr1         </th>    
            <th>PhoneNr2         </th>    
            <th>Gender           </th>    
            <th>PostalCode       </th>    
            <th>City             </th>    
            <th>Monthly Contribution</th>    
            </tr>
        </thead>
        ");
            builder.OpenElement(27, "tbody");
            builder.AddContent(28, "\n");
#line 70 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
             foreach (var emp in studList)
            {

#line default
#line hidden
            builder.AddContent(29, "                ");
            builder.OpenElement(30, "tr");
            builder.AddContent(31, "\n                    ");
            builder.OpenElement(32, "td");
            builder.AddContent(33, emp.Name);
            builder.AddContent(34, "             ");
            builder.CloseElement();
            builder.AddContent(35, "    \n                    ");
            builder.OpenElement(36, "td");
            builder.AddContent(37, emp.Surname);
            builder.AddContent(38, "          ");
            builder.CloseElement();
            builder.AddContent(39, "    \n                    ");
            builder.OpenElement(40, "td");
            builder.AddContent(41, emp.Branch);
            builder.AddContent(42, "           ");
            builder.CloseElement();
            builder.AddContent(43, "    \n                    ");
            builder.OpenElement(44, "td");
            builder.AddContent(45, emp.Birthday);
            builder.AddContent(46, "         ");
            builder.CloseElement();
            builder.AddContent(47, "    \n                    ");
            builder.OpenElement(48, "td");
            builder.AddContent(49, emp.EntryDate);
            builder.AddContent(50, "        ");
            builder.CloseElement();
            builder.AddContent(51, "    \n                    ");
            builder.OpenElement(52, "td");
            builder.AddContent(53, emp.LeavingDate);
            builder.AddContent(54, "      ");
            builder.CloseElement();
            builder.AddContent(55, "    \n                    ");
            builder.OpenElement(56, "td");
            builder.AddContent(57, emp.arClass);
            builder.AddContent(58, "          ");
            builder.CloseElement();
            builder.AddContent(59, "    \n                    ");
            builder.OpenElement(60, "td");
            builder.AddContent(61, emp.qClass);
            builder.AddContent(62, "           ");
            builder.CloseElement();
            builder.AddContent(63, "    \n                    ");
            builder.OpenElement(64, "td");
            builder.AddContent(65, emp.PhoneNr1);
            builder.AddContent(66, "         ");
            builder.CloseElement();
            builder.AddContent(67, "    \n                    ");
            builder.OpenElement(68, "td");
            builder.AddContent(69, emp.PhoneNr2);
            builder.AddContent(70, "         ");
            builder.CloseElement();
            builder.AddContent(71, "    \n                    ");
            builder.OpenElement(72, "td");
            builder.AddContent(73, emp.Gender);
            builder.AddContent(74, "           ");
            builder.CloseElement();
            builder.AddContent(75, "    \n                    ");
            builder.OpenElement(76, "td");
            builder.AddContent(77, emp.PostalCode);
            builder.AddContent(78, "       ");
            builder.CloseElement();
            builder.AddContent(79, "    \n                    ");
            builder.OpenElement(80, "td");
            builder.AddContent(81, emp.City);
            builder.AddContent(82, "             ");
            builder.CloseElement();
            builder.AddContent(83, "    \n                    ");
            builder.OpenElement(84, "td");
            builder.AddContent(85, emp.MonthContribution);
            builder.CloseElement();
            builder.AddContent(86, "    \n                    ");
            builder.OpenElement(87, "td");
            builder.AddContent(88, "\n                        ");
            builder.OpenElement(89, "button");
            builder.AddAttribute(90, "class", "btn btn-info");
            builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await EditStudent(@emp.Id)));
            builder.AddContent(92, "Edit");
            builder.CloseElement();
            builder.AddContent(93, "\n                        ");
            builder.OpenElement(94, "button");
            builder.AddAttribute(95, "class", "btn btn-danger");
            builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await DeleteConfirm(@emp.Id)));
            builder.AddContent(97, "Delete");
            builder.CloseElement();
            builder.AddContent(98, "\n                    ");
            builder.CloseElement();
            builder.AddContent(99, "\n                ");
            builder.CloseElement();
            builder.AddContent(100, "\n");
#line 92 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
            }

#line default
#line hidden
            builder.AddContent(101, "        ");
            builder.CloseElement();
            builder.AddContent(102, "\n    ");
            builder.CloseElement();
            builder.AddContent(103, "\n");
#line 95 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"

    if (isAdd)
    {

#line default
#line hidden
            builder.AddContent(104, "        ");
            builder.OpenElement(105, "div");
            builder.AddAttribute(106, "style", "overflow:auto;height:80%");
            builder.AddContent(107, "\n        ");
            builder.OpenElement(108, "div");
            builder.AddAttribute(109, "class", "modal");
            builder.AddAttribute(110, "tabindex", "-1");
            builder.AddAttribute(111, "style", "display:block");
            builder.AddAttribute(112, "role", "dialog");
            builder.AddContent(113, "\n            ");
            builder.OpenElement(114, "div");
            builder.AddAttribute(115, "class", "modal-dialog");
            builder.AddContent(116, "\n                ");
            builder.OpenElement(117, "div");
            builder.AddAttribute(118, "class", "modal-content");
            builder.AddContent(119, "\n                    ");
            builder.OpenElement(120, "div");
            builder.AddAttribute(121, "class", "modal-header");
            builder.AddContent(122, "\n                        ");
            builder.OpenElement(123, "h3");
            builder.AddAttribute(124, "class", "modal-title");
            builder.AddContent(125, modalTitle);
            builder.CloseElement();
            builder.AddContent(126, "\n                        ");
            builder.OpenElement(127, "button");
            builder.AddAttribute(128, "type", "button");
            builder.AddAttribute(129, "class", "close");
            builder.AddAttribute(130, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(closeModal));
            builder.AddContent(131, "\n                            ");
            builder.AddMarkupContent(132, "<span aria-hidden=\"true\">X</span>\n                        ");
            builder.CloseElement();
            builder.AddContent(133, "\n                    ");
            builder.CloseElement();
            builder.AddContent(134, "\n                    ");
            builder.OpenElement(135, "div");
            builder.AddAttribute(136, "class", "modal-body");
            builder.AddContent(137, "\n                        ");
            builder.OpenElement(138, "form");
            builder.AddContent(139, "\n                            ");
            builder.OpenElement(140, "div");
            builder.AddAttribute(141, "class", "form-group");
            builder.AddContent(142, "\n                                ");
            builder.AddMarkupContent(143, "<label for=\"Name\" class=\"my-control-label\">Name</label>\n                                ");
            builder.OpenElement(144, "input");
            builder.AddAttribute(145, "for", "Name");
            builder.AddAttribute(146, "class", "form-control");
            builder.AddAttribute(147, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.Name));
            builder.AddAttribute(148, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.Name = __value, stud.Name));
            builder.CloseElement();
            builder.AddContent(149, "\n                            ");
            builder.CloseElement();
            builder.AddContent(150, "\n                            ");
            builder.OpenElement(151, "div");
            builder.AddAttribute(152, "class", "form-group");
            builder.AddContent(153, "\n                                ");
            builder.AddMarkupContent(154, "<label for=\"Surname\" class=\"my-control-label\">Surame</label>\n                                ");
            builder.OpenElement(155, "input");
            builder.AddAttribute(156, "for", "SurName");
            builder.AddAttribute(157, "class", "form-control");
            builder.AddAttribute(158, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.Surname));
            builder.AddAttribute(159, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.Surname = __value, stud.Surname));
            builder.CloseElement();
            builder.AddContent(160, "\n                            ");
            builder.CloseElement();
            builder.AddContent(161, "\n                            ");
            builder.OpenElement(162, "div");
            builder.AddAttribute(163, "class", "form-group");
            builder.AddContent(164, "\n                                ");
            builder.AddMarkupContent(165, "<label for=\"Branch\" class=\"my-control-label\">Branch</label>\n                                ");
            builder.OpenElement(166, "select");
            builder.AddAttribute(167, "for", "Branch");
            builder.AddAttribute(168, "class", "form-control");
            builder.AddAttribute(169, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.Branch));
            builder.AddAttribute(170, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.Branch = __value, stud.Branch));
            builder.AddContent(171, "\n                                    ");
            builder.AddMarkupContent(172, "<option value=\"\">-- Select Branch --</option>\n");
#line 122 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                     foreach (var city in branchList)
                                    {

#line default
#line hidden
            builder.AddContent(173, "                                        ");
            builder.OpenElement(174, "option");
            builder.AddAttribute(175, "value", city.Name);
            builder.AddContent(176, city.Name);
            builder.CloseElement();
            builder.AddContent(177, "\n");
#line 125 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                    }

#line default
#line hidden
            builder.AddContent(178, "                                ");
            builder.CloseElement();
            builder.AddContent(179, "\n                            ");
            builder.CloseElement();
            builder.AddContent(180, "\n                            ");
            builder.OpenElement(181, "div");
            builder.AddAttribute(182, "class", "form-group");
            builder.AddContent(183, "\n                                ");
            builder.AddMarkupContent(184, "<label for=\"Birthday\" class=\"my-control-label\">Birthday</label>\n                                ");
            builder.OpenElement(185, "input");
            builder.AddAttribute(186, "for", "Birthday");
            builder.AddAttribute(187, "class", "form-control");
            builder.AddAttribute(188, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.Birthday));
            builder.AddAttribute(189, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.Birthday = __value, stud.Birthday));
            builder.CloseElement();
            builder.AddContent(190, "\n                            ");
            builder.CloseElement();
            builder.AddContent(191, "\n                            ");
            builder.OpenElement(192, "div");
            builder.AddAttribute(193, "class", "form-group");
            builder.AddContent(194, "\n                                ");
            builder.AddMarkupContent(195, "<label for=\"EntryDate\" class=\"my-control-label\">Entry Date</label>\n                                ");
            builder.OpenElement(196, "input");
            builder.AddAttribute(197, "for", "EntryDate");
            builder.AddAttribute(198, "class", "form-control");
            builder.AddAttribute(199, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.EntryDate));
            builder.AddAttribute(200, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.EntryDate = __value, stud.EntryDate));
            builder.CloseElement();
            builder.AddContent(201, "\n                            ");
            builder.CloseElement();
            builder.AddContent(202, "\n                            ");
            builder.OpenElement(203, "div");
            builder.AddAttribute(204, "class", "form-group");
            builder.AddContent(205, "\n                                ");
            builder.AddMarkupContent(206, "<label for=\"LeavingDate\" class=\"my-control-label\">LeavingDate</label>\n                                ");
            builder.OpenElement(207, "input");
            builder.AddAttribute(208, "for", "LeavingDate");
            builder.AddAttribute(209, "class", "form-control");
            builder.AddAttribute(210, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.LeavingDate));
            builder.AddAttribute(211, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.LeavingDate = __value, stud.LeavingDate));
            builder.CloseElement();
            builder.AddContent(212, "\n                            ");
            builder.CloseElement();
            builder.AddContent(213, "\n                            ");
            builder.OpenElement(214, "div");
            builder.AddAttribute(215, "class", "form-group");
            builder.AddContent(216, "\n                                ");
            builder.AddMarkupContent(217, "<label asp-for=\"arClass\" class=\"my-control-label\">Arabic Class</label>\n                                ");
            builder.OpenElement(218, "select");
            builder.AddAttribute(219, "asp-for", "arClass");
            builder.AddAttribute(220, "class", "form-control");
            builder.AddAttribute(221, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.arClass));
            builder.AddAttribute(222, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.arClass = __value, stud.arClass));
            builder.AddContent(223, "\n                                    ");
            builder.AddMarkupContent(224, "<option value=\"\">-- Select arclass --</option>\n");
#line 144 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                     foreach (var city in arClassList)
                                    {

#line default
#line hidden
            builder.AddContent(225, "                                        ");
            builder.OpenElement(226, "option");
            builder.AddAttribute(227, "value", city.Name);
            builder.AddContent(228, city.Name);
            builder.CloseElement();
            builder.AddContent(229, "\n");
#line 147 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                    }

#line default
#line hidden
            builder.AddContent(230, "                                ");
            builder.CloseElement();
            builder.AddContent(231, "\n                            ");
            builder.CloseElement();
            builder.AddContent(232, "\n                            ");
            builder.OpenElement(233, "div");
            builder.AddAttribute(234, "class", "form-group");
            builder.AddContent(235, "\n                                ");
            builder.AddMarkupContent(236, "<label asp-for=\"qClass\" class=\"my-control-label\">Quran Class</label>\n                                ");
            builder.OpenElement(237, "select");
            builder.AddAttribute(238, "asp-for", "qClass");
            builder.AddAttribute(239, "class", "form-control");
            builder.AddAttribute(240, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.qClass));
            builder.AddAttribute(241, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.qClass = __value, stud.qClass));
            builder.AddContent(242, "\n                                    ");
            builder.AddMarkupContent(243, "<option value=\"\">-- Select qclass --</option>\n");
#line 154 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                     foreach (var city in qClassList)
                                    {

#line default
#line hidden
            builder.AddContent(244, "                                        ");
            builder.OpenElement(245, "option");
            builder.AddAttribute(246, "value", city.Name);
            builder.AddContent(247, city.Name);
            builder.CloseElement();
            builder.AddContent(248, "\n");
#line 157 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                    }

#line default
#line hidden
            builder.AddContent(249, "                                ");
            builder.CloseElement();
            builder.AddContent(250, "\n                            ");
            builder.CloseElement();
            builder.AddContent(251, "\n                            ");
            builder.OpenElement(252, "div");
            builder.AddAttribute(253, "class", "form-group");
            builder.AddContent(254, "\n                                ");
            builder.AddMarkupContent(255, "<label asp-for=\"Gender\" class=\"my-control-label\">Gender</label>\n                                ");
            builder.OpenElement(256, "select");
            builder.AddAttribute(257, "asp-for", "Gender");
            builder.AddAttribute(258, "class", "form-control");
            builder.AddAttribute(259, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.Gender));
            builder.AddAttribute(260, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.Gender = __value, stud.Gender));
            builder.AddContent(261, "\n                                    ");
            builder.AddMarkupContent(262, "<option value=\"\">-- Select Gender --</option>\n");
#line 164 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                     foreach (var city in genderList)
                                    {

#line default
#line hidden
            builder.AddContent(263, "                                        ");
            builder.OpenElement(264, "option");
            builder.AddAttribute(265, "value", city);
            builder.AddContent(266, city);
            builder.CloseElement();
            builder.AddContent(267, "\n");
#line 167 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
                                    }

#line default
#line hidden
            builder.AddContent(268, "                                ");
            builder.CloseElement();
            builder.AddContent(269, "\n                            ");
            builder.CloseElement();
            builder.AddContent(270, "\n                            ");
            builder.OpenElement(271, "div");
            builder.AddAttribute(272, "class", "form-group");
            builder.AddContent(273, "\n                                ");
            builder.AddMarkupContent(274, "<label asp-for=\"PhoneNr1\" class=\"my-control-label\">PhoneNr1</label>\n                                ");
            builder.OpenElement(275, "input");
            builder.AddAttribute(276, "asp-for", "PhoneNr1");
            builder.AddAttribute(277, "class", "form-control");
            builder.AddAttribute(278, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.PhoneNr1));
            builder.AddAttribute(279, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.PhoneNr1 = __value, stud.PhoneNr1));
            builder.CloseElement();
            builder.AddContent(280, "\n                            ");
            builder.CloseElement();
            builder.AddContent(281, "\n                            ");
            builder.OpenElement(282, "div");
            builder.AddAttribute(283, "class", "form-group");
            builder.AddContent(284, "\n                                ");
            builder.AddMarkupContent(285, "<label asp-for=\"PhoneNr2\" class=\"my-control-label\">PhoneNr2</label>\n                                ");
            builder.OpenElement(286, "input");
            builder.AddAttribute(287, "asp-for", "PhoneNr2");
            builder.AddAttribute(288, "class", "form-control");
            builder.AddAttribute(289, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.PhoneNr2));
            builder.AddAttribute(290, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.PhoneNr2 = __value, stud.PhoneNr2));
            builder.CloseElement();
            builder.AddContent(291, "\n                            ");
            builder.CloseElement();
            builder.AddContent(292, "\n                            ");
            builder.OpenElement(293, "div");
            builder.AddAttribute(294, "class", "form-group");
            builder.AddContent(295, "\n                                ");
            builder.AddMarkupContent(296, "<label asp-for=\"PostalCode\" class=\"my-control-label\">Postal Code</label>\n                                ");
            builder.OpenElement(297, "input");
            builder.AddAttribute(298, "asp-for", "PostalCode");
            builder.AddAttribute(299, "class", "form-control");
            builder.AddAttribute(300, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.PostalCode));
            builder.AddAttribute(301, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.PostalCode = __value, stud.PostalCode));
            builder.CloseElement();
            builder.AddContent(302, "\n                            ");
            builder.CloseElement();
            builder.AddContent(303, "\n                            ");
            builder.OpenElement(304, "div");
            builder.AddAttribute(305, "class", "form-group");
            builder.AddContent(306, "\n                                ");
            builder.AddMarkupContent(307, "<label asp-for=\"City\" class=\"my-control-label\">City</label>\n                                ");
            builder.OpenElement(308, "input");
            builder.AddAttribute(309, "asp-for", "City");
            builder.AddAttribute(310, "class", "form-control");
            builder.AddAttribute(311, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.City));
            builder.AddAttribute(312, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.City = __value, stud.City));
            builder.CloseElement();
            builder.AddContent(313, "\n                            ");
            builder.CloseElement();
            builder.AddContent(314, "\n                            ");
            builder.OpenElement(315, "div");
            builder.AddAttribute(316, "class", "form-group");
            builder.AddContent(317, "\n                                ");
            builder.AddMarkupContent(318, "<label asp-for=\"MonthContribution\" class=\"my-control-label\">Monthly Contribution</label>\n                                ");
            builder.OpenElement(319, "input");
            builder.AddAttribute(320, "asp-for", "MonthContribution");
            builder.AddAttribute(321, "class", "form-control");
            builder.AddAttribute(322, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(stud.MonthContribution));
            builder.AddAttribute(323, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => stud.MonthContribution = __value, stud.MonthContribution));
            builder.CloseElement();
            builder.AddContent(324, "\n                            ");
            builder.CloseElement();
            builder.AddContent(325, "\n                        ");
            builder.CloseElement();
            builder.AddContent(326, "\n                    ");
            builder.CloseElement();
            builder.AddContent(327, "\n                    ");
            builder.OpenElement(328, "div");
            builder.AddAttribute(329, "class", "modal-footer");
            builder.AddContent(330, "\n                        ");
            builder.OpenElement(331, "button");
            builder.AddAttribute(332, "class", "btn btn-block btn-success");
            builder.AddAttribute(333, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await SaveStudent()));
            builder.AddAttribute(334, "data-dismiss", "modal");
            builder.AddContent(335, "Save");
            builder.CloseElement();
            builder.AddContent(336, "\n                    ");
            builder.CloseElement();
            builder.AddContent(337, "\n                    \n                ");
            builder.CloseElement();
            builder.AddContent(338, "\n            ");
            builder.CloseElement();
            builder.AddContent(339, "\n        ");
            builder.CloseElement();
            builder.AddContent(340, "\n    ");
            builder.CloseElement();
            builder.AddContent(341, "   \n");
#line 200 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
    }

    if (isDelete)
    {

#line default
#line hidden
            builder.AddContent(342, "        ");
            builder.OpenElement(343, "div");
            builder.AddAttribute(344, "class", "modal");
            builder.AddAttribute(345, "tabindex", "-1");
            builder.AddAttribute(346, "style", "display:block");
            builder.AddAttribute(347, "role", "dialog");
            builder.AddContent(348, "\n            ");
            builder.OpenElement(349, "div");
            builder.AddAttribute(350, "class", "modal-dialog");
            builder.AddContent(351, "\n                ");
            builder.OpenElement(352, "div");
            builder.AddAttribute(353, "class", "modal-content");
            builder.AddContent(354, "\n                    ");
            builder.AddMarkupContent(355, "<div class=\"modal-header\">\n                        <h3 class=\"modal-title\">Delete Employee</h3>\n                    </div>\n                    ");
            builder.OpenElement(356, "div");
            builder.AddAttribute(357, "class", "modal-body");
            builder.AddContent(358, "\n                        ");
            builder.AddMarkupContent(359, "<h4>Do you want to delete this employee ??</h4>\n                        ");
            builder.OpenElement(360, "table");
            builder.AddAttribute(361, "class", "table");
            builder.AddContent(362, "\n                            ");
            builder.OpenElement(363, "tr");
            builder.AddContent(364, "\n                                ");
            builder.AddMarkupContent(365, "<td>Name</td>\n                                ");
            builder.OpenElement(366, "td");
            builder.AddContent(367, stud.Name);
            builder.CloseElement();
            builder.AddContent(368, "\n                            ");
            builder.CloseElement();
            builder.AddContent(369, "\n                            ");
            builder.OpenElement(370, "tr");
            builder.AddContent(371, "\n                                ");
            builder.AddMarkupContent(372, "<td>Gender</td>\n                                ");
            builder.OpenElement(373, "td");
            builder.AddContent(374, stud.Gender);
            builder.CloseElement();
            builder.AddContent(375, "\n                            ");
            builder.CloseElement();
            builder.AddContent(376, "\n                            ");
            builder.OpenElement(377, "tr");
            builder.AddContent(378, "\n                                ");
            builder.AddMarkupContent(379, "<td>Department</td>\n                                ");
            builder.OpenElement(380, "td");
            builder.AddContent(381, stud.arClass);
            builder.CloseElement();
            builder.AddContent(382, "\n                            ");
            builder.CloseElement();
            builder.AddContent(383, "\n                            ");
            builder.OpenElement(384, "tr");
            builder.AddContent(385, "\n                                ");
            builder.AddMarkupContent(386, "<td>City</td>\n                                ");
            builder.OpenElement(387, "td");
            builder.AddContent(388, stud.City);
            builder.CloseElement();
            builder.AddContent(389, "\n                            ");
            builder.CloseElement();
            builder.AddContent(390, "\n                        ");
            builder.CloseElement();
            builder.AddContent(391, "\n                    ");
            builder.CloseElement();
            builder.AddContent(392, "\n                    ");
            builder.OpenElement(393, "div");
            builder.AddAttribute(394, "class", "modal-footer");
            builder.AddContent(395, "\n                        ");
            builder.OpenElement(396, "button");
            builder.AddAttribute(397, "class", "btn btn-danger");
            builder.AddAttribute(398, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await DeleteStudent(stud.Id)));
            builder.AddAttribute(399, "data-dismiss", "modal");
            builder.AddContent(400, "YES");
            builder.CloseElement();
            builder.AddContent(401, "\n                        ");
            builder.OpenElement(402, "button");
            builder.AddAttribute(403, "class", "btn btn-warning");
            builder.AddAttribute(404, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(closeModal));
            builder.AddContent(405, "NO");
            builder.CloseElement();
            builder.AddContent(406, "\n                    ");
            builder.CloseElement();
            builder.AddContent(407, "\n                ");
            builder.CloseElement();
            builder.AddContent(408, "\n            ");
            builder.CloseElement();
            builder.AddContent(409, "\n        ");
            builder.CloseElement();
            builder.AddContent(410, "\n");
#line 238 "D:\Projects\vscode\blazor\AlMadrasa\AlMadrasa.Client\Pages\StudentData.cshtml"
    }
}  

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
