﻿using System;
using System.IO;
using System.Linq;
using Microsoft.Owin.Diagnostics.Views;

namespace OWinHost.AspNet48.WebApi
{
#line 1 "ErrorPage.cshtml"

#line default
#line hidden

#line 2 "ErrorPage.cshtml"
#line default
#line hidden

#line 3 "ErrorPage.cshtml"
#line default
#line hidden

#line 4 "ErrorPage.cshtml"

#line default
#line hidden

    public class ErrorPage : BaseView
    {
        private StreamWriter _output;

        /// <summary>
        /// </summary>
        public ErrorPageModel Model { get; set; }

      
        public override void Execute()
        {
            
#line 12 "ErrorPage.cshtml"

            this.Response.StatusCode    = 500;
            this.Response.ReasonPhrase  = "Internal Server Error";
            this.Response.ContentType   = "text/html";
            this.Response.ContentLength = null; // Clear any prior Content-Length
            var location = string.Empty;

#line default
#line hidden
            this.WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

            this.WriteAttribute("lang", Tuple.Create(" lang=\"", 461), Tuple.Create("\"", 543)
#line 20 "ErrorPage.cshtml"
                              , Tuple.Create(Tuple.Create("", 468),
                                             Tuple.Create<object, int
                                             >(System.Globalization.CultureInfo.CurrentUICulture.TwoLetterISOLanguageName
#line default
#line hidden
                                             , 468), false)
                               );

            this.WriteLiteral("  xmlns=\"http://www.w3.org/1999/xhtml\"");

            this.WriteLiteral(">\r\n    <head>\r\n        <meta");

            this.WriteLiteral(" charset=\"utf-8\"");

            this.WriteLiteral(" />\r\n        <title>");

#line 23 "ErrorPage.cshtml"
            this.Write(Resources.ErrorPageHtml_Title);

#line default
#line hidden
            this.WriteLiteral("</title>\r\n        <style>\r\n");

            this.WriteLiteral("            ");

#line 25 "ErrorPage.cshtml"
            this.WriteLiteral(@"body {
    font-family: 'Segoe UI',Tahoma,Arial,Helvetica,sans-serif;
    font-size: .813em;
    line-height: 1.4em;
    color: #222;
}

h1, h2, h3, h4, h5 {
    /*font-family: 'Segoe UI',Tahoma,Arial,Helvetica,sans-serif;*/
    font-weight: 100;
}

h1 {
    color: #44525e;
    margin: 15px 0 15px 0;
}

h2 {
    margin: 10px 5px 0 0;
}

h3 {
    color: #363636;
    margin: 5px 5px 0 0;
}

code {
    font-family: consolas, ""Courier New"", courier, monospace;
}

body .titleerror {
    padding: 3px;
}

body .location {
    margin: 3px 0 10px 30px;
}

#header {
    font-size: 18px;
    padding-left: 0px;
    padding-right: 0px;
    padding-top: 15px;
    padding-bottom: 15px;
    border-top: 1px #ddd solid;
    border-bottom: 1px #ddd solid;
    margin-bottom: 0px;
}

#header li {
    display: inline;
    margin: 5px;
    padding: 5px;
    color: #a0a0a0;
    cursor: pointer;
}

#header li:hover {
    background: #A9E4F9;
    color: #fff;
}

#header li.selected {
    background: #44C5F2;
    color: #fff;
}

#stackpage ul {
    list-style: none;
    padding-left: 0;
    margin: 0;
    /*border-bottom: 1px #ddd solid;*/
}

#stackpage .stackerror {
    padding: 5px;
    border-bottom: 1px #ddd solid;
}

#stackpage .stackerror:hover {
    background-color: #f0f0f0;
}

#stackpage .frame:hover {
    background-color: #f0f0f0;
    text-decoration: none;
}

#stackpage .frame {
    padding: 2px;
    margin: 0 0 0 30px;
    border-bottom: 1px #ddd solid;
}

#stackpage .frame h3 {
    padding: 5px;
    margin: 0;
}

#stackpage .source {
    padding: 0px;
}

#stackpage .source ol li {
    font-family: consolas, ""Courier New"", courier, monospace;
    white-space: pre;
}

#stackpage .source ol.highlight li {
    /*color: #e22;*/
    /*font-weight: bold;*/
}

#stackpage .source ol.highlight li span {
    /*color: #000;*/
}

#stackpage .frame:hover .source ol.highlight li span {
    color: #fff;
    background: #B20000;
}

#stackpage .source ol.collapsable li {
    color: #888;
}

#stackpage .source ol.collapsable li span {
    color: #606060;
}

.page table {
    border-collapse: separate;
    border-spacing: 0;
    margin: 0 0 20px;
}

.page th {
    vertical-align: bottom;
    padding: 10px 5px 5px 5px;
    font-weight: 400;
    color: #a0a0a0;
    text-align: left;
}

.page td {
    padding: 3px 10px;
}

.page th, .page td {
    border-right: 1px #ddd solid;
    border-bottom: 1px #ddd solid;
    border-left: 1px transparent solid;
    border-top: 1px transparent solid;
    box-sizing: border-box;
}

.page th:last-child, .page td:last-child {
    border-right: 1px transparent solid;
}

.page td.length {
    text-align: right;
}

a {
    color: #1ba1e2;
    text-decoration: none;
}

a:hover {
    color: #13709e;
    text-decoration: underline;
}
");

#line default
#line hidden
            this.WriteLiteral(" \r\n        </style>\r\n    </head>\r\n    <body>\r\n        <h1>");

#line 29 "ErrorPage.cshtml"
            this.Write(Resources.ErrorPageHtml_UnhandledException);

#line default
#line hidden
            this.WriteLiteral("</h1>\r\n");

#line 30 "ErrorPage.cshtml"

#line default
#line hidden

#line 30 "ErrorPage.cshtml"
            if (this.Model.Options.ShowExceptionDetails)
            {
                foreach (var errorDetail in this.Model.ErrorDetails)
                {
#line default
#line hidden
                    this.WriteLiteral("                <h2");

                    this.WriteLiteral(" class=\"titleerror\"");

                    this.WriteLiteral(">");

#line 34 "ErrorPage.cshtml"
                    this.Write(errorDetail.Error.GetType().Name);

#line default
#line hidden
                    this.WriteLiteral(": ");

#line 34 "ErrorPage.cshtml"
                    this.Write(errorDetail.Error.Message);

#line default
#line hidden
                    this.WriteLiteral("</h2>\r\n");

#line 35 "ErrorPage.cshtml"

#line default
#line hidden

#line 35 "ErrorPage.cshtml"

                    StackFrame firstFrame = null;
                    firstFrame = errorDetail.StackFrames.FirstOrDefault();
                    if (firstFrame != null)
                    {
                        location = firstFrame.Function;
                    }
                    else if (errorDetail.Error.TargetSite != null && errorDetail.Error.TargetSite.DeclaringType != null)
                    {
                        location = errorDetail.Error.TargetSite.DeclaringType.FullName + "." +
                                   errorDetail.Error.TargetSite.Name;
                    }

#line default
#line hidden

#line 46 "ErrorPage.cshtml"

                    if (!string.IsNullOrEmpty(location) && firstFrame != null && !string.IsNullOrEmpty(firstFrame.File))
                    {
#line default
#line hidden
                        this.WriteLiteral("                    <p");

                        this.WriteLiteral(" class=\"location\"");

                        this.WriteLiteral(">");

#line 49 "ErrorPage.cshtml"
                        this.Write(location);

#line default
#line hidden
                        this.WriteLiteral(" in <code");

                        this.WriteAttribute("title", Tuple.Create(" title=\"", 1899), Tuple.Create("\"", 1923)
#line 49 "ErrorPage.cshtml"
                                          , Tuple.Create(Tuple.Create("", 1907),
                                                         Tuple.Create<object, int>(firstFrame.File
#line default
#line hidden
                                                                                 , 1907), false)
                                           );

                        this.WriteLiteral(">");

#line 49 "ErrorPage.cshtml"
                        this.Write(System.IO.Path.GetFileName(firstFrame.File));

#line default
#line hidden
                        this.WriteLiteral("</code>, line ");

#line 49 "ErrorPage.cshtml"
                        this.Write(firstFrame.Line);

#line default
#line hidden
                        this.WriteLiteral("</p>\r\n");

#line 50 "ErrorPage.cshtml"
                    }
                    else if (!string.IsNullOrEmpty(location))
                    {
#line default
#line hidden
                        this.WriteLiteral("                    <p");

                        this.WriteLiteral(" class=\"location\"");

                        this.WriteLiteral(">");

#line 53 "ErrorPage.cshtml"
                        this.Write(location);

#line default
#line hidden
                        this.WriteLiteral("</p>\r\n");

#line 54 "ErrorPage.cshtml"
                    }
                    else
                    {
#line default
#line hidden
                        this.WriteLiteral("                    <p");

                        this.WriteLiteral(" class=\"location\"");

                        this.WriteLiteral(">");

#line 57 "ErrorPage.cshtml"
                        this.Write(Resources.ErrorPageHtml_UnknownLocation);

#line default
#line hidden
                        this.WriteLiteral("</p>\r\n");

#line 58 "ErrorPage.cshtml"
                    }
                }
            }
            else
            {
#line default
#line hidden
                this.WriteLiteral("            <h2>");

#line 63 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_EnableShowExceptions);

#line default
#line hidden
                this.WriteLiteral("</h2>\r\n");

#line 64 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        <ul");

            this.WriteLiteral(" id=\"header\"");

            this.WriteLiteral(">\r\n");

#line 66 "ErrorPage.cshtml"

#line default
#line hidden

#line 66 "ErrorPage.cshtml"
            if (this.Model.Options.ShowExceptionDetails)
            {
#line default
#line hidden
                this.WriteLiteral("                <li");

                this.WriteLiteral(" id=\"stack\"");

                this.WriteLiteral(" tabindex=\"1\"");

                this.WriteLiteral(" class=\"selected\"");

                this.WriteLiteral(">\r\n");

                this.WriteLiteral("                    ");

#line 69 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_StackButton);

#line default
#line hidden
                this.WriteLiteral("\r\n                </li>\r\n");

#line 71 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("            ");

#line 72 "ErrorPage.cshtml"
            if (this.Model.Options.ShowQuery)
            {
#line default
#line hidden
                this.WriteLiteral("                <li");

                this.WriteLiteral(" id=\"query\"");

                this.WriteLiteral(" tabindex=\"2\"");

                this.WriteLiteral(">\r\n");

                this.WriteLiteral("                    ");

#line 75 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_QueryButton);

#line default
#line hidden
                this.WriteLiteral("\r\n                </li>\r\n");

#line 77 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("            ");

#line 78 "ErrorPage.cshtml"
            if (this.Model.Options.ShowCookies)
            {
#line default
#line hidden
                this.WriteLiteral("                <li");

                this.WriteLiteral(" id=\"cookies\"");

                this.WriteLiteral(" tabindex=\"3\"");

                this.WriteLiteral(">\r\n");

                this.WriteLiteral("                    ");

#line 81 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_CookiesButton);

#line default
#line hidden
                this.WriteLiteral("\r\n                </li>\r\n");

#line 83 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("            ");

#line 84 "ErrorPage.cshtml"
            if (this.Model.Options.ShowHeaders)
            {
#line default
#line hidden
                this.WriteLiteral("                <li");

                this.WriteLiteral(" id=\"headers\"");

                this.WriteLiteral(" tabindex=\"4\"");

                this.WriteLiteral(">\r\n");

                this.WriteLiteral("                    ");

#line 87 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_HeadersButton);

#line default
#line hidden
                this.WriteLiteral("\r\n                </li>\r\n");

#line 89 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("            ");

#line 90 "ErrorPage.cshtml"
            if (this.Model.Options.ShowEnvironment)
            {
#line default
#line hidden
                this.WriteLiteral("                <li");

                this.WriteLiteral(" id=\"environment\"");

                this.WriteLiteral(" tabindex=\"5\"");

                this.WriteLiteral(">\r\n");

                this.WriteLiteral("                    ");

#line 93 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_EnvironmentButton);

#line default
#line hidden
                this.WriteLiteral("\r\n                </li>\r\n");

#line 95 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        </ul>\r\n");

#line 97 "ErrorPage.cshtml"

#line default
#line hidden

#line 97 "ErrorPage.cshtml"
            if (this.Model.Options.ShowExceptionDetails)
            {
#line default
#line hidden
                this.WriteLiteral("            <div");

                this.WriteLiteral(" id=\"stackpage\"");

                this.WriteLiteral(" class=\"page\"");

                this.WriteLiteral(">\r\n                <ul>\r\n");

#line 101 "ErrorPage.cshtml"

#line default
#line hidden

#line 101 "ErrorPage.cshtml"
                var tabIndex = 6;

#line default
#line hidden
                this.WriteLiteral("\r\n");

#line 102 "ErrorPage.cshtml"

#line default
#line hidden

#line 102 "ErrorPage.cshtml"
                foreach (var errorDetail in this.Model.ErrorDetails)
                {
#line default
#line hidden
                    this.WriteLiteral("                        <li>\r\n                            <h2");

                    this.WriteLiteral(" class=\"stackerror\"");

                    this.WriteLiteral(">");

#line 105 "ErrorPage.cshtml"
                    this.Write(errorDetail.Error.GetType().Name);

#line default
#line hidden
                    this.WriteLiteral(": ");

#line 105 "ErrorPage.cshtml"
                    this.Write(errorDetail.Error.Message);

#line default
#line hidden
                    this.WriteLiteral("</h2>\r\n                            <ul>\r\n");

#line 107 "ErrorPage.cshtml"

#line default
#line hidden

#line 107 "ErrorPage.cshtml"
                    foreach (var frame in errorDetail.StackFrames)
                    {
#line default
#line hidden
                        this.WriteLiteral("                                <li");

                        this.WriteLiteral(" class=\"frame\"");

                        this.WriteAttribute("tabindex", Tuple.Create(" tabindex=\"", 4158), Tuple.Create("\"", 4178)
#line 109 "ErrorPage.cshtml"
                                          , Tuple.Create(Tuple.Create("", 4169), Tuple.Create<object, int>(tabIndex
#line default
#line hidden
                                                                                                         , 4169), false)
                                           );

                        this.WriteLiteral(">\r\n");

#line 110 "ErrorPage.cshtml"

#line default
#line hidden

#line 110 "ErrorPage.cshtml"
                        tabIndex++;

#line default
#line hidden
                        this.WriteLiteral("\r\n");

#line 111 "ErrorPage.cshtml"

#line default
#line hidden

#line 111 "ErrorPage.cshtml"
                        if (string.IsNullOrEmpty(frame.File))
                        {
#line default
#line hidden
                            this.WriteLiteral("                                        <h3>");

#line 113 "ErrorPage.cshtml"
                            this.Write(frame.Function);

#line default
#line hidden
                            this.WriteLiteral("</h3>\r\n");

#line 114 "ErrorPage.cshtml"
                        }
                        else
                        {
#line default
#line hidden
                            this.WriteLiteral("                                        <h3>");

#line 117 "ErrorPage.cshtml"
                            this.Write(frame.Function);

#line default
#line hidden
                            this.WriteLiteral(" in <code");

                            this.WriteAttribute("title", Tuple.Create(" title=\"", 4605), Tuple.Create("\"", 4624)
#line 117 "ErrorPage.cshtml"
                                              , Tuple.Create(Tuple.Create("", 4613),
                                                             Tuple.Create<object, int>(frame.File
#line default
#line hidden
                                                                                     , 4613), false)
                                               );

                            this.WriteLiteral(">");

#line 117 "ErrorPage.cshtml"
                            this.Write(System.IO.Path.GetFileName(frame.File));

#line default
#line hidden
                            this.WriteLiteral("</code></h3>\r\n");

#line 118 "ErrorPage.cshtml"
                        }

#line default
#line hidden
                        this.WriteLiteral("\r\n");

#line 120 "ErrorPage.cshtml"

#line default
#line hidden

#line 120 "ErrorPage.cshtml"
                        if (frame.Line != 0 && frame.ContextCode != null)
                        {
#line default
#line hidden
                            this.WriteLiteral("                                        <div");

                            this.WriteLiteral(" class=\"source\"");

                            this.WriteLiteral(">\r\n");

#line 123 "ErrorPage.cshtml"

#line default
#line hidden

#line 123 "ErrorPage.cshtml"
                            if (frame.PreContextCode != null)
                            {
#line default
#line hidden
                                this.WriteLiteral("                                                <ol");

                                this.WriteAttribute("start", Tuple.Create(" start=\"", 5087), Tuple.Create("\"", 5116)
#line 125 "ErrorPage.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 5095),
                                                                 Tuple.Create<object, int>(frame.PreContextLine
#line default
#line hidden
                                                                                         , 5095), false)
                                                   );

                                this.WriteLiteral(" class=\"collapsible\"");

                                this.WriteLiteral(">\r\n");

#line 126 "ErrorPage.cshtml"

#line default
#line hidden

#line 126 "ErrorPage.cshtml"
                                foreach (var line in frame.PreContextCode)
                                {
#line default
#line hidden
                                    this.WriteLiteral("                                                        <li><span>");

#line 128 "ErrorPage.cshtml"
                                    this.Write(line);

#line default
#line hidden
                                    this.WriteLiteral("</span></li>\r\n");

#line 129 "ErrorPage.cshtml"
                                }

#line default
#line hidden
                                this.WriteLiteral("                                                </ol>\r\n");

#line 131 "ErrorPage.cshtml"
                            }

#line default
#line hidden
                            this.WriteLiteral("\r\n                                            <ol");

                            this.WriteAttribute("start", Tuple.Create(" start=\"", 5584), Tuple.Create("\"", 5603)
#line 133 "ErrorPage.cshtml"
                                              , Tuple.Create(Tuple.Create("", 5592),
                                                             Tuple.Create<object, int>(frame.Line
#line default
#line hidden
                                                                                     , 5592), false)
                                               );

                            this.WriteLiteral(" class=\"highlight\"");

                            this.WriteLiteral(">\r\n                                                <li><span>");

#line 134 "ErrorPage.cshtml"
                            this.Write(frame.ContextCode);

#line default
#line hidden
                            this.WriteLiteral("</span></li></ol>\r\n\r\n");

#line 136 "ErrorPage.cshtml"

#line default
#line hidden

#line 136 "ErrorPage.cshtml"
                            if (frame.PostContextCode != null)
                            {
#line default
#line hidden
                                this.WriteLiteral("                                                <ol");

                                this.WriteAttribute("start", Tuple.Create(" start=\'", 5901), Tuple.Create("\'", 5926)
#line 138 "ErrorPage.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 5909),
                                                                 Tuple.Create<object, int>(frame.Line + 1
#line default
#line hidden
                                                                                         , 5909), false)
                                                   );

                                this.WriteLiteral(" class=\"collapsible\"");

                                this.WriteLiteral(">\r\n");

#line 139 "ErrorPage.cshtml"

#line default
#line hidden

#line 139 "ErrorPage.cshtml"
                                foreach (var line in frame.PostContextCode)
                                {
#line default
#line hidden
                                    this.WriteLiteral("                                                        <li><span>");

#line 141 "ErrorPage.cshtml"
                                    this.Write(line);

#line default
#line hidden
                                    this.WriteLiteral("</span></li>\r\n");

#line 142 "ErrorPage.cshtml"
                                }

#line default
#line hidden
                                this.WriteLiteral("                                                </ol>\r\n");

#line 144 "ErrorPage.cshtml"
                            }

#line default
#line hidden
                            this.WriteLiteral("                                        </div>\r\n");

#line 146 "ErrorPage.cshtml"
                        }

#line default
#line hidden
                        this.WriteLiteral("                                </li>\r\n");

#line 148 "ErrorPage.cshtml"
                    }

#line default
#line hidden
                    this.WriteLiteral("                            </ul>\r\n                        </li>\r\n");

#line 151 "ErrorPage.cshtml"
                }

#line default
#line hidden
                this.WriteLiteral("                </ul>\r\n            </div>\r\n");

#line 154 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        ");

#line 155 "ErrorPage.cshtml"
            if (this.Model.Options.ShowQuery)
            {
#line default
#line hidden
                this.WriteLiteral("            <div");

                this.WriteLiteral(" id=\"querypage\"");

                this.WriteLiteral(" class=\"page\"");

                this.WriteLiteral(">\r\n");

#line 158 "ErrorPage.cshtml"

#line default
#line hidden

#line 158 "ErrorPage.cshtml"
                if (this.Model.Query.Any())
                {
#line default
#line hidden
                    this.WriteLiteral("                    <table>\r\n                        <thead>\r\n                   " +
                                      "         <tr>\r\n                                <th>");

#line 163 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                                <th>");

#line 164 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
                                      "                   <tbody>\r\n");

#line 168 "ErrorPage.cshtml"

#line default
#line hidden

#line 168 "ErrorPage.cshtml"
                    foreach (var kv in this.Model.Query.OrderBy(kv => kv.Key))
                    {
                        foreach (var v in kv.Value)
                        {
#line default
#line hidden
                            this.WriteLiteral("                                    <tr>\r\n                                       " +
                                              " <td>");

#line 173 "ErrorPage.cshtml"
                            this.Write(kv.Key);

#line default
#line hidden
                            this.WriteLiteral("</td>\r\n                                        <td>");

#line 174 "ErrorPage.cshtml"
                            this.Write(v);

#line default
#line hidden
                            this.WriteLiteral("</td>\r\n                                    </tr>\r\n");

#line 176 "ErrorPage.cshtml"
                        }
                    }

#line default
#line hidden
                    this.WriteLiteral("                        </tbody>\r\n                    </table>\r\n");

#line 180 "ErrorPage.cshtml"
                }
                else
                {
#line default
#line hidden
                    this.WriteLiteral("                    <p>");

#line 183 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_NoQueryStringData);

#line default
#line hidden
                    this.WriteLiteral("</p>\r\n");

#line 184 "ErrorPage.cshtml"
                }

#line default
#line hidden
                this.WriteLiteral("            </div>\r\n");

#line 186 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        ");

#line 187 "ErrorPage.cshtml"
            if (this.Model.Options.ShowCookies)
            {
#line default
#line hidden
                this.WriteLiteral("            <div");

                this.WriteLiteral(" id=\"cookiespage\"");

                this.WriteLiteral(" class=\"page\"");

                this.WriteLiteral(">\r\n");

#line 190 "ErrorPage.cshtml"

#line default
#line hidden

#line 190 "ErrorPage.cshtml"
                if (this.Model.Cookies.Any())
                {
#line default
#line hidden
                    this.WriteLiteral("                    <table>\r\n                        <thead>\r\n                   " +
                                      "         <tr>\r\n                                <th>");

#line 195 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                                <th>");

#line 196 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
                                      "                   <tbody>\r\n");

#line 200 "ErrorPage.cshtml"

#line default
#line hidden

#line 200 "ErrorPage.cshtml"
                    foreach (var kv in this.Model.Cookies.OrderBy(kv => kv.Key))
                    {
#line default
#line hidden
                        this.WriteLiteral("                                <tr>\r\n                                    <td>");

#line 203 "ErrorPage.cshtml"
                        this.Write(kv.Key);

#line default
#line hidden
                        this.WriteLiteral("</td>\r\n                                    <td>");

#line 204 "ErrorPage.cshtml"
                        this.Write(kv.Value);

#line default
#line hidden
                        this.WriteLiteral("</td>\r\n                                </tr>\r\n");

#line 206 "ErrorPage.cshtml"
                    }

#line default
#line hidden
                    this.WriteLiteral("                        </tbody>\r\n                    </table>\r\n");

#line 209 "ErrorPage.cshtml"
                }
                else
                {
#line default
#line hidden
                    this.WriteLiteral("                    <p>");

#line 212 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_NoCookieData);

#line default
#line hidden
                    this.WriteLiteral("</p>\r\n");

#line 213 "ErrorPage.cshtml"
                }

#line default
#line hidden
                this.WriteLiteral("            </div>\r\n");

#line 215 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        ");

#line 216 "ErrorPage.cshtml"
            if (this.Model.Options.ShowHeaders)
            {
#line default
#line hidden
                this.WriteLiteral("            <div");

                this.WriteLiteral(" id=\"headerspage\"");

                this.WriteLiteral(" class=\"page\"");

                this.WriteLiteral(">\r\n");

#line 219 "ErrorPage.cshtml"

#line default
#line hidden

#line 219 "ErrorPage.cshtml"
                if (this.Model.Headers.Any())
                {
#line default
#line hidden
                    this.WriteLiteral("                    <table>\r\n                        <thead>\r\n                   " +
                                      "         <tr>\r\n                                <th>");

#line 224 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                                <th>");

#line 225 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
                    this.WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
                                      "                   <tbody>\r\n");

#line 229 "ErrorPage.cshtml"

#line default
#line hidden

#line 229 "ErrorPage.cshtml"
                    foreach (var kv in this.Model.Headers.OrderBy(kv => kv.Key))
                    {
                        foreach (var v in kv.Value)
                        {
#line default
#line hidden
                            this.WriteLiteral("                                    <tr>\r\n                                       " +
                                              " <td>");

#line 234 "ErrorPage.cshtml"
                            this.Write(kv.Key);

#line default
#line hidden
                            this.WriteLiteral("</td>\r\n                                        <td>");

#line 235 "ErrorPage.cshtml"
                            this.Write(v);

#line default
#line hidden
                            this.WriteLiteral("</td>\r\n                                    </tr>\r\n");

#line 237 "ErrorPage.cshtml"
                        }
                    }

#line default
#line hidden
                    this.WriteLiteral("                        </tbody>\r\n                    </table>\r\n");

#line 241 "ErrorPage.cshtml"
                }
                else
                {
#line default
#line hidden
                    this.WriteLiteral("                    <p>");

#line 244 "ErrorPage.cshtml"
                    this.Write(Resources.ErrorPageHtml_NoHeaderData);

#line default
#line hidden
                    this.WriteLiteral("</p>\r\n");

#line 245 "ErrorPage.cshtml"
                }

#line default
#line hidden
                this.WriteLiteral("            </div>\r\n");

#line 247 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        ");

#line 248 "ErrorPage.cshtml"
            if (this.Model.Options.ShowEnvironment)
            {
#line default
#line hidden
                this.WriteLiteral("            <div");

                this.WriteLiteral(" id=\"environmentpage\"");

                this.WriteLiteral(" class=\"page\"");

                this.WriteLiteral(">\r\n                <table>\r\n                    <thead>\r\n                        " +
                                  "<tr>\r\n                            <th>");

#line 254 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_VariableColumn);

#line default
#line hidden
                this.WriteLiteral("</th>\r\n                            <th>");

#line 255 "ErrorPage.cshtml"
                this.Write(Resources.ErrorPageHtml_ValueColumn);

#line default
#line hidden
                this.WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
                                  "       <tbody>\r\n");

#line 259 "ErrorPage.cshtml"

#line default
#line hidden

#line 259 "ErrorPage.cshtml"
                foreach (var kv in this.Model.Environment.OrderBy(kv => kv.Key))
                {
#line default
#line hidden
                    this.WriteLiteral("                            <tr>\r\n                                <td>");

#line 262 "ErrorPage.cshtml"
                    this.Write(kv.Key);

#line default
#line hidden
                    this.WriteLiteral("</td>\r\n                                <td>");

#line 263 "ErrorPage.cshtml"
                    this.Write(kv.Value);

#line default
#line hidden
                    this.WriteLiteral("</td>\r\n                            </tr>\r\n");

#line 265 "ErrorPage.cshtml"
                }

#line default
#line hidden
                this.WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");

#line 269 "ErrorPage.cshtml"
            }

#line default
#line hidden
            this.WriteLiteral("        <script");

            this.WriteLiteral(" type=\"text/javascript\"");

            this.WriteLiteral(">\r\n        //<!--\r\n");

            this.WriteLiteral("            ");

#line 272 "ErrorPage.cshtml"
            this.WriteLiteral(@"(function (window, undefined) {
    ""use strict"";

    function $(selector, element) {
        return new NodeCollection(selector, element);
    }

    function NodeCollection(selector, element) {
        this.items = [];
        element = element || window.document;

        var nodeList;

        if (typeof (selector) === ""string"") {
            nodeList = element.querySelectorAll(selector);
            for (var i = 0, l = nodeList.length; i < l; i++) {
                this.items.push(nodeList.item(i));
            }
        } else if (selector.tagName) {
            this.items.push(selector);
        } else if (selector.splice) {
            this.items = this.items.concat(selector);
        }
    }

    NodeCollection.prototype = {
        each: function (callback) {
            for (var i = 0, l = this.items.length; i < l; i++) {
                callback(this.items[i], i);
            }
            return this;
        },

        children: function (selector) {
            var children = [];

            this.each(function (el) {
                children = children.concat($(selector, el).items);
            });

            return $(children);
        },

        hide: function () {
            this.each(function (el) {
                el.style.display = ""none"";
            });

            return this;
        },

        toggle: function () {
            this.each(function (el) {
                el.style.display = el.style.display === ""none"" ? """" : ""none"";
            });

            return this;
        },

        show: function () {
            this.each(function (el) {
                el.style.display = """";
            });

            return this;
        },

        addClass: function (className) {
            this.each(function (el) {
                var existingClassName = el.className,
                    classNames;
                if (!existingClassName) {
                    el.className = className;
                } else {
                    classNames = existingClassName.split("" "");
                    if (classNames.indexOf(className) < 0) {
                        el.className = existingClassName + "" "" + className;
                    }
                }
            });

            return this;
        },

        removeClass: function (className) {
            this.each(function (el) {
                var existingClassName = el.className,
                    classNames, index;
                if (existingClassName === className) {
                    el.className = """";
                } else if (existingClassName) {
                    classNames = existingClassName.split("" "");
                    index = classNames.indexOf(className);
                    if (index > 0) {
                        classNames.splice(index, 1);
                        el.className = classNames.join("" "");
                    }
                }
            });

            return this;
        },

        toggleClass: function (className) {
            this.each(function (el) {
                var classNames = el.className.split("" "");
                if (classNames.indexOf(className) >= 0) {
                    $(el).removeClass(className);
                } else {
                    $(el).addClass(className);
                }
            });

            return this;
        },

        attr: function (name) {
            if (this.items.length === 0) {
                return null;
            }

            return this.items[0].getAttribute(name);
        },

        on: function (eventName, handler) {
            this.each(function (el, idx) {
                var callback = function (e) {
                    e = e || window.event;
                    if (!e.which && e.keyCode) {
                        e.which = e.keyCode; // Normalize IE8 key events
                    }
                    handler.apply(el, [e]);
                };

                if (el.addEventListener) { // DOM Events
                    el.addEventListener(eventName, callback, false);
                } else if (el.attachEvent) { // IE8 events
                    el.attachEvent(""on"" + eventName, callback);
                } else {
                    el[""on"" + type] = callback;
                }
            });

            return this;
        },

        click: function (handler) {
            return this.on(""click"", handler);
        },

        keypress: function (handler) {
            return this.on(""keypress"", handler);
        }
    };

    function frame(el) {
        $(el).children("".source .collapsible"").toggle();
    }

    function tab(el) {
        var unselected = $(""#header .selected"").removeClass(""selected"").attr(""id"");
        var selected = $(el).addClass(""selected"").attr(""id"");

        $(""#"" + unselected + ""page"").hide();
        $(""#"" + selected + ""page"").show();
    }

    $("".collapsible"").hide();
    $("".page"").hide();
    $(""#stackpage"").show();

    $("".frame"")
        .click(function () {
            frame(this);
        })
        .keypress(function (e) {
            if (e.which === 13) {
                frame(this);
            }
        });

    $(""#header li"")
        .click(function () {
            tab(this);
        })
        .keypress(function (e) {
            if (e.which === 13) {
                tab(this);
            }
        });
})(window);");

#line default
#line hidden
            this.WriteLiteral("\r\n        //-->\r\n        </script>\r\n    </body>\r\n</html>\r\n");
        }
    }
}