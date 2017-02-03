<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venda.aspx.cs" Inherits="Supermercado.Venda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelTitulo" runat="server" Text="Supermercado Boa Esperança"></asp:Label>
        <br/>
        <hr>
        <br/>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="codigoDoProduto" HeaderText="Código" SortExpression="codigoDoProduto" />
                <asp:BoundField DataField="descricaoDoProduto" HeaderText="Produto" SortExpression="descricaoDoProduto" />
                <asp:BoundField DataField="valorUnitario" HeaderText="Valor" SortExpression="valorUnitario" DataFormatString="{0:C}" />
                <asp:ButtonField Text="Adicionar ao Carrinho" ButtonType="Button" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SupermercadoConnectionString %>" SelectCommand="SELECT * FROM [Produtos]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
