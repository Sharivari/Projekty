<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DziennikOcenWeb2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 180px;
        }
        .auto-style2 {
            height: 26px;
        }
    </style>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div aria-orientation="horizontal"; style="text-align: center;">
    
        Email:
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
&nbsp;Hasło:
        <asp:TextBox ID="TextBoxHaslo" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Zaloguj" OnClick="Button1_Click" />
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Student" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Prowadzacy" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Admin" />
    
    </div>
        <table style="font-family: 'Times New Roman', Times, serif; border: medium hidden #000000; line-height: normal; text-align: center; border-collapse: separate;">
            <tr runat="server" id="Przedmiott">
                <td class="auto-style1" style="height: auto">
                    <asp:GridView ID="gvPrzedmiot" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_PRZEDMIOTU" DataSourceID="edsPrzedmiot">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_PRZEDMIOTU" HeaderText="id_PRZEDMIOTU" ReadOnly="True" SortExpression="id_PRZEDMIOTU" />
                            <asp:BoundField DataField="nazwa_przedmiotu" HeaderText="nazwa_przedmiotu" SortExpression="nazwa_przedmiotu" />
                            <asp:BoundField DataField="opis_przedmiotu" HeaderText="opis_przedmiotu" SortExpression="opis_przedmiotu" />
                            <asp:BoundField DataField="ECTS" HeaderText="ECTS" SortExpression="ECTS" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td class="auto-style1" style="height: auto">
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id_PRZEDMIOTU" DataSourceID="edsPrzedmiot" DefaultMode="Insert" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="nazwa_przedmiotu" HeaderText="nazwa_przedmiotu" SortExpression="nazwa_przedmiotu" />
                            <asp:BoundField DataField="opis_przedmiotu" HeaderText="opis_przedmiotu" SortExpression="opis_przedmiotu" />
                            <asp:BoundField DataField="ECTS" HeaderText="ECTS" SortExpression="ECTS" />
                            <asp:CommandField ShowInsertButton="True" />
                        </Fields>
                    </asp:DetailsView>
                </td>
            </tr>
            <tr runat="server" id="Projektt">
                <td>
                    <asp:GridView ID="gvProjekt" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_PROJEKTU" DataSourceID="edsProjekt">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_PROJEKTU" HeaderText="id_PROJEKTU" ReadOnly="True" SortExpression="id_PROJEKTU" />
                            <asp:BoundField DataField="id_PRZEDMIOTU" HeaderText="id_PRZEDMIOTU" SortExpression="id_PRZEDMIOTU" />
                            <asp:BoundField DataField="nazwa_projektu" HeaderText="nazwa_projektu" SortExpression="nazwa_projektu" />
                            <asp:BoundField DataField="opis_projektu" HeaderText="opis_projektu" SortExpression="opis_projektu" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;" runat="server" id="ProjektTable">
                        <tr runat="server" id="ProjektID">
                            <td>ID przedmiotu</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Projekt_idPrzedmiotu" runat="server" DataSourceID="edsPrzedmiot" DataTextField="id_PRZEDMIOTU" DataValueField="id_PRZEDMIOTU">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektNazwa">
                            <td class="auto-style2">Nazwa projektu</td>
                            <td class="auto-style2">
                                <asp:TextBox ID="TextBox_Projekt_nazwaProjektu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektOpis">
                            <td>Opis projektu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekt_opisProjektu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajProjekt" runat="server" OnClick="Button_DodajProjekt_Click" Text="Dodaj" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                                <asp:DropDownList ID="DropDownList_Student_zapiszsiedoprojektu" runat="server" DataSourceID="edsProjekt" DataTextField="id_PROJEKTU" DataValueField="id_PROJEKTU">
                    </asp:DropDownList>
                                <asp:Button ID="Button_Student_zapiszsiedoprojektu" runat="server" OnClick="Button_Student_zapiszsiedoprojektu_Click" Text="Zapisz się do projektu" />
                </td>
            </tr>
            <tr runat="server" id="Grupaa">
                <td>
                    <asp:GridView ID="gvGrupa" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_GRUPY" DataSourceID="edsGrupa">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_GRUPY" HeaderText="id_GRUPY" ReadOnly="True" SortExpression="id_GRUPY" />
                            <asp:BoundField DataField="nazwa_grupy" HeaderText="nazwa_grupy" SortExpression="nazwa_grupy" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataKeyNames="id_GRUPY" DataSourceID="edsGrupa" DefaultMode="Insert" Height="50px" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="nazwa_grupy" HeaderText="nazwa_grupy" SortExpression="nazwa_grupy" />
                            <asp:CommandField CancelText="Anuluj" InsertText="Dodaj" ShowInsertButton="True" />
                        </Fields>
                    </asp:DetailsView>
                </td>
            </tr>
            <tr runat="server" id="Studentt">
                <td>
                    <asp:GridView ID="gvStudent" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_STUDENTA" DataSourceID="edsStudent">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_STUDENTA" HeaderText="id_STUDENTA" ReadOnly="True" SortExpression="id_STUDENTA" />
                            <asp:BoundField DataField="id_GRUPY" HeaderText="id_GRUPY" SortExpression="id_GRUPY" />
                            <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                            <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                            <asp:BoundField DataField="telefon" HeaderText="telefon" SortExpression="telefon" />
                            <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
                            <asp:BoundField DataField="e_mail" HeaderText="e_mail" SortExpression="e_mail" />
                            <asp:BoundField DataField="haslo" HeaderText="haslo" SortExpression="haslo" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;">
                        <tr>
                            <td>ID grupy</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Student_idGrupy" runat="server" DataSourceID="edsGrupa" DataTextField="id_GRUPY" DataValueField="id_GRUPY">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Imię</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_imie" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Nazwisko</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_nazwisko" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Telefon</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_telefon" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Adres</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_adres" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Email</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_email" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Hasło</td>
                            <td>
                                <asp:TextBox ID="TextBox_Student_haslo" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajStudent" runat="server" OnClick="Button_DodajStudent_Click" Text="Dodaj" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server" id="Prowadzacyy">
                <td>
                    <asp:GridView ID="gvProwadzacy" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_PROWADZĄCEGO" DataSourceID="edsProwadzacy">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_PROWADZĄCEGO" HeaderText="id_PROWADZĄCEGO" ReadOnly="True" SortExpression="id_PROWADZĄCEGO" />
                            <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                            <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                            <asp:BoundField DataField="telefon" HeaderText="telefon" SortExpression="telefon" />
                            <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
                            <asp:BoundField DataField="e_mail" HeaderText="e_mail" SortExpression="e_mail" />
                            <asp:BoundField DataField="haslo" HeaderText="haslo" SortExpression="haslo" />
                            <asp:BoundField DataField="stanowisko" HeaderText="stanowisko" SortExpression="stanowisko" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:DetailsView ID="DetailsView3" runat="server" AutoGenerateRows="False" DataKeyNames="id_PROWADZĄCEGO" DataSourceID="edsProwadzacy" DefaultMode="Insert" Height="50px" Width="125px">
                        <Fields>
                            <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                            <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                            <asp:BoundField DataField="telefon" HeaderText="telefon" SortExpression="telefon" />
                            <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
                            <asp:BoundField DataField="e_mail" HeaderText="e_mail" SortExpression="e_mail" />
                            <asp:BoundField DataField="haslo" HeaderText="haslo" SortExpression="haslo" />
                            <asp:BoundField DataField="stanowisko" HeaderText="stanowisko" SortExpression="stanowisko" />
                            <asp:CommandField CancelText="Anuluj" InsertText="Dodaj" ShowInsertButton="True" />
                        </Fields>
                    </asp:DetailsView>
                </td>
            </tr>
            <tr runat="server" id="Projektyy">
                <td>
                    <asp:GridView ID="gvProjekty" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_STUDENTA,id_PROJEKTU,id_PROWADZĄCEGO" DataSourceID="edsProjekty">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_STUDENTA" HeaderText="id_STUDENTA" ReadOnly="True" SortExpression="id_STUDENTA" />
                            <asp:BoundField DataField="id_PROJEKTU" HeaderText="id_PROJEKTU" ReadOnly="True" SortExpression="id_PROJEKTU" />
                            <asp:BoundField DataField="id_PROWADZĄCEGO" HeaderText="id_PROWADZĄCEGO" ReadOnly="True" SortExpression="id_PROWADZĄCEGO" />
                            <asp:BoundField DataField="ocena_projektu" HeaderText="ocena_projektu" SortExpression="ocena_projektu" />
                            <asp:BoundField DataField="data_projektu" HeaderText="data_projektu" SortExpression="data_projektu" />
                            <asp:BoundField DataField="uwagi_projektu" HeaderText="uwagi_projektu" SortExpression="uwagi_projektu" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;"  runat="server" id="ProjektyTable">
                        <tr runat="server" id="ProjektyIDStudenta">
                            <td class="auto-style2">ID studenta</td>
                            <td class="auto-style2">
                                <asp:DropDownList ID="DropDownList_Projekty_idStudenta" runat="server" DataSourceID="edsStudent" DataTextField="id_STUDENTA" DataValueField="id_STUDENTA">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyIDProjektu">
                            <td>ID projektu</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Projekty_idProjektu" runat="server" DataSourceID="edsProjekt" DataTextField="id_PROJEKTU" DataValueField="id_PROJEKTU">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyIDProwadzacego">
                            <td>ID prowadzącego</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Projekty_idProwadzacego" runat="server" DataSourceID="edsProwadzacy" DataTextField="id_PROWADZĄCEGO" DataValueField="id_PROWADZĄCEGO">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyOcena">
                            <td>Ocena</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_ocena" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyData">
                            <td>Data projektu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_dataProjektu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyUwagi">
                            <td>Uwagi</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_uwagi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajProjekty" runat="server" OnClick="Button_DodajProjekty_Click" Text="Dodaj" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server" id="Przedmiotyy">
                <td>
                    <asp:GridView ID="gvPrzedmioty" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_STUDENTA,id_PROWADZĄCEGO,id_PRZEDMIOTU" DataSourceID="edsPrzedmioty">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_STUDENTA" HeaderText="id_STUDENTA" ReadOnly="True" SortExpression="id_STUDENTA" />
                            <asp:BoundField DataField="id_PROWADZĄCEGO" HeaderText="id_PROWADZĄCEGO" ReadOnly="True" SortExpression="id_PROWADZĄCEGO" />
                            <asp:BoundField DataField="id_PRZEDMIOTU" HeaderText="id_PRZEDMIOTU" ReadOnly="True" SortExpression="id_PRZEDMIOTU" />
                            <asp:BoundField DataField="ocena_przedmiotu" HeaderText="ocena_przedmiotu" SortExpression="ocena_przedmiotu" />
                            <asp:BoundField DataField="data_zaliczenia_przedmiotu" HeaderText="data_zaliczenia_przedmiotu" SortExpression="data_zaliczenia_przedmiotu" />
                            <asp:BoundField DataField="uwagi_przedmiotu" HeaderText="uwagi_przedmiotu" SortExpression="uwagi_przedmiotu" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;" runat="server" id="PrzedmiotyTable">
                        <tr>
                            <td>ID studenta</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idStudenta" runat="server" DataSourceID="edsStudent" DataTextField="id_STUDENTA" DataValueField="id_STUDENTA">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>ID prowadzącego</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idProwadzacego" runat="server" DataSourceID="edsProwadzacy" DataTextField="id_PROWADZĄCEGO" DataValueField="id_PROWADZĄCEGO">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>ID przedmiotu</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idPrzedmiotu" runat="server" DataSourceID="edsPrzedmiot" DataTextField="id_PRZEDMIOTU" DataValueField="id_PRZEDMIOTU">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyOcena">
                            <td>Ocena przedmiotu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_ocenaPrzedmiotu" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyData">
                            <td>Data zaliczenia</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_dataZaliczenia" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyUwagi">
                            <td>Uwagi przedmiotu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_uwagi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajPrzedmioty" runat="server" OnClick="Button_DodajPrzedmioty_Click" Text="Dodaj" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server" id="PrzedmiotyyKonkretny">
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_STUDENTA,id_PROWADZĄCEGO,id_PRZEDMIOTU" DataSourceID="edsPrzedmiotyKonkretny" AllowPaging="True">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_STUDENTA" HeaderText="id_STUDENTA" ReadOnly="True" SortExpression="id_STUDENTA" />
                            <asp:BoundField DataField="id_PROWADZĄCEGO" HeaderText="id_PROWADZĄCEGO" ReadOnly="True" SortExpression="id_PROWADZĄCEGO" />
                            <asp:BoundField DataField="id_PRZEDMIOTU" HeaderText="id_PRZEDMIOTU" ReadOnly="True" SortExpression="id_PRZEDMIOTU" />
                            <asp:BoundField DataField="ocena_przedmiotu" HeaderText="ocena_przedmiotu" SortExpression="ocena_przedmiotu" />
                            <asp:BoundField DataField="data_zaliczenia_przedmiotu" HeaderText="data_zaliczenia_przedmiotu" SortExpression="data_zaliczenia_przedmiotu" />
                            <asp:BoundField DataField="uwagi_przedmiotu" HeaderText="uwagi_przedmiotu" SortExpression="uwagi_przedmiotu" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;" runat="server" id="PrzedmiotyTable0">
                        <tr>
                            <td>ID studenta</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idStudenta0" runat="server" DataSourceID="edsStudent" DataTextField="id_STUDENTA" DataValueField="id_STUDENTA">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>ID prowadzącego</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idProwadzacego0" runat="server" DataSourceID="edsProwadzacy" DataTextField="id_PROWADZĄCEGO" DataValueField="id_PROWADZĄCEGO">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>ID przedmiotu</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Przedmioty_idPrzedmiotu0" runat="server" DataSourceID="edsPrzedmiot" DataTextField="id_PRZEDMIOTU" DataValueField="id_PRZEDMIOTU">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyOcena0">
                            <td>Ocena przedmiotu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_ocenaPrzedmiotu0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyData0">
                            <td>Data zaliczenia</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_dataZaliczenia0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="PrzedmiotyUwagi0">
                            <td>Uwagi przedmiotu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Przedmioty_uwagi0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajPrzedmioty0" runat="server" OnClick="Button_DodajPrzedmioty_Click" Text="Dodaj" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr runat="server" id="ProjektyyKonkretny">
                <td>
                    <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_STUDENTA,id_PROJEKTU,id_PROWADZĄCEGO" DataSourceID="edsProjektyKonkretny">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="id_STUDENTA" HeaderText="id_STUDENTA" ReadOnly="True" SortExpression="id_STUDENTA" />
                            <asp:BoundField DataField="id_PROJEKTU" HeaderText="id_PROJEKTU" ReadOnly="True" SortExpression="id_PROJEKTU" />
                            <asp:BoundField DataField="id_PROWADZĄCEGO" HeaderText="id_PROWADZĄCEGO" ReadOnly="True" SortExpression="id_PROWADZĄCEGO" />
                            <asp:BoundField DataField="ocena_projektu" HeaderText="ocena_projektu" SortExpression="ocena_projektu" />
                            <asp:BoundField DataField="data_projektu" HeaderText="data_projektu" SortExpression="data_projektu" />
                            <asp:BoundField DataField="uwagi_projektu" HeaderText="uwagi_projektu" SortExpression="uwagi_projektu" />
                        </Columns>
                        <HeaderStyle CssClass="tablebackheader" />
                        <RowStyle CssClass="tableback" />
                    </asp:GridView>
                </td>
                <td>
                    <table style="width:100%;"  runat="server" id="ProjektyTable0">
                        <tr runat="server" id="ProjektyIDStudenta0">
                            <td class="auto-style2">ID studenta</td>
                            <td class="auto-style2">
                                <asp:DropDownList ID="DropDownList_Projekty_idStudenta0" runat="server" DataSourceID="edsStudent" DataTextField="id_STUDENTA" DataValueField="id_STUDENTA">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyIDProjektu0">
                            <td>ID projektu</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Projekty_idProjektu0" runat="server" DataSourceID="edsProjekt" DataTextField="id_PROJEKTU" DataValueField="id_PROJEKTU">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyIDProwadzacego0">
                            <td>ID prowadzącego</td>
                            <td>
                                <asp:DropDownList ID="DropDownList_Projekty_idProwadzacego0" runat="server" DataSourceID="edsProwadzacy" DataTextField="id_PROWADZĄCEGO" DataValueField="id_PROWADZĄCEGO">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyOcena0">
                            <td>Ocena</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_ocena0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyData0">
                            <td>Data projektu</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_dataProjektu0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr runat="server" id="ProjektyUwagi0">
                            <td>Uwagi</td>
                            <td>
                                <asp:TextBox ID="TextBox_Projekty_uwagi0" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button_DodajProjekty0" runat="server" OnClick="Button_DodajProjekty_Click" Text="Dodaj" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:EntityDataSource ID="edsPrzedmiot" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="PRZEDMIOT">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsProjekt" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="PROJEKT">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsGrupa" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="GRUPA">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsStudent" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="STUDENT">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsProwadzacy" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="PROWADZĄCY">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsProjekty" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="projekty">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsPrzedmioty" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="przedmioty" >
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsPrzedmiotyKonkretny" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="przedmioty" Where="it.[id_PROWADZĄCEGO] = 1" EntityTypeFilter="" Select="">
        </asp:EntityDataSource>
        <asp:EntityDataSource ID="edsProjektyKonkretny" runat="server" ConnectionString="name=DziennikOcenEntities" DefaultContainerName="DziennikOcenEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="projekty" Where="it.[id_PROWADZĄCEGO] = 1">
        </asp:EntityDataSource>
    </form>
</body>
</html>
