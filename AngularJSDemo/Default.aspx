﻿<%@ Page Title="Main Tax Form" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="AngularJSDemo._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <base href="/AngularJSDemo/">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <script src="AngularApp/MainTaxForm/App.js" type="text/javascript"></script>
    <script src="AngularApp/MainTaxForm/Controllers/TaxFormController.js" type="text/javascript"></script>
    <script src="AngularApp/MainTaxForm/Controllers/EmploymentController.js" type="text/javascript"></script>
    <script src="AngularApp/MainTaxForm/Services/TaxFormService.js" type="text/javascript"></script>
    <%--    <script>
        //        angular.bootstrap(document.getElementById("mainTaxForm"), ['mainTaxForm']);
    </script>--%>
    <div data-ng-app="mainTaxFormApp">
        <div dvw ng-view>
            <%--<div>{{subTotal | json}}</div>--%>
            <div class="jumbotron text-center">
                <h1>
                    EDIT MY TAX FORM
                </h1>
                <small>Declare/Claim any income/deductions/reliefs that is NOT reflected in the IDRS
                    Select below the type of changes you wish to make</small>
            </div>
            <div class="list-group">
                <a href="#" class="list-group-item">
                    <h4 class="list-group-item-heading">
                        Trade, Business, Profession or Vocation <span class="pull-right">{{subTotal.TotalBusinessIncome
                            | currency }}</span>
                    </h4>
                </a><a ng-href="#/Employment" class="list-group-item">
                    <h4 class="list-group-item-heading">
                        Employment Income and Expenses <span class="pull-right">{{subTotal.TotalEmploymentIncome
                            | currency }} </span>
                    </h4>
                </a><a href="#" class="list-group-item">
                    <h4 class="list-group-item-heading">
                        Other Income<span class="pull-right">{{subTotal.GrandTotalDeductions | currency }}</span></h4>
                </a><a href="#" class="list-group-item">
                    <h4 class="list-group-item-heading">
                        Deductions and Reliefs<span class="pull-right">{{subTotal.txtTotalOtherIncome | currency
                            }}</span></h4>
                </a>
                <div class="list-group-item list-group-item-info">
                    <h4 class="list-group-item-heading">
                        Total Income Less Expenses <span class="pull-right">{{ ((subTotal.TotalBusinessIncome
                            | num) + (subTotal.TotalEmploymentIncome | num) + (subTotal.GrandTotalDeductions
                            | num)) | currency }}</span>
                    </h4>
                </div>
                <div class="list-group-item">
                    <h4 class="list-group-item-heading">
                        Singapore Tax Deducted At Source<span class="pull-right">{{0 | currency }}</span>
                    </h4>
                </div>
            </div>
            <div class="text-center">
                <input type="button" class="btn btn-primary" ng-click="updateTaxFormData()" value="SAVE DRAFT &amp; EXIT" />
            </div>
        </div>
    </div>
</asp:Content>
