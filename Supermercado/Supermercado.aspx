<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supermercado.aspx.cs" Inherits="Supermercado.Supermercado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LabelTituloSupermercado" runat="server" Text="Supermercado"></asp:Label>
        <hr/>
        <asp:GridView ID="GridViewProduto" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSourceProduto" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridViewProduto_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="codigoDoProduto" HeaderText="Código" SortExpression="codigoDoProduto" />
                <asp:BoundField DataField="descricaoDoProduto" HeaderText="Descrição" SortExpression="descricaoDoProduto" />
                <asp:BoundField DataField="valorUnitario" DataFormatString="{0:f2}" HeaderText="Valor (R$)" SortExpression="valorUnitario" />
                <asp:ButtonField ButtonType="Button" CommandName="Adicionar_carrinho" Text="Adicionar ao Carrinho" />
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
    </div>
        <asp:SqlDataSource ID="SqlDataSourceProduto" runat="server" ConnectionString="<%$ ConnectionStrings:SupermercadoConnectionString %>" DeleteCommand="DELETE FROM [Produtos] WHERE [id] = @id" InsertCommand="INSERT INTO [Produtos] ([codigoDoProduto], [descricaoDoProduto], [quantidadeNoPedido], [quantidadeEmEstoque], [valorUnitario]) VALUES (@codigoDoProduto, @descricaoDoProduto, @quantidadeNoPedido, @quantidadeEmEstoque, @valorUnitario)" SelectCommand="SELECT * FROM [Produtos]" UpdateCommand="UPDATE [Produtos] SET [codigoDoProduto] = @codigoDoProduto, [descricaoDoProduto] = @descricaoDoProduto, [quantidadeNoPedido] = @quantidadeNoPedido, [quantidadeEmEstoque] = @quantidadeEmEstoque, [valorUnitario] = @valorUnitario WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="codigoDoProduto" Type="Int32" />
                <asp:Parameter Name="descricaoDoProduto" Type="String" />
                <asp:Parameter Name="quantidadeNoPedido" Type="Int32" />
                <asp:Parameter Name="quantidadeEmEstoque" Type="Int32" />
                <asp:Parameter Name="valorUnitario" Type="Double" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="codigoDoProduto" Type="Int32" />
                <asp:Parameter Name="descricaoDoProduto" Type="String" />
                <asp:Parameter Name="quantidadeNoPedido" Type="Int32" />
                <asp:Parameter Name="quantidadeEmEstoque" Type="Int32" />
                <asp:Parameter Name="valorUnitario" Type="Double" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
