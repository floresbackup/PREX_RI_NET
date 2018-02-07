<%@ Page Language="VB" AutoEventWireup="false" CodeFile="queryexec.aspx.vb" Inherits="Pages_queryexec" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dxwpg" %>

<%@ Register Assembly="DevExpress.Web.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dxtc" %>
<%@ Register Assembly="DevExpress.Web.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.Web.ASPxClasses" TagPrefix="dxw" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.XtraCharts.v8.2.Web, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v8.2, Version=8.2.2.0, Culture=neutral, PublicKeyToken=49d90c14d24271b5"
    Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Qualitas Reporting Web - Ejecutar consulta</title>
</head>
<body>
    <form id="queryexec" runat="server">
    <div>
        <dxtc:ASPxPageControl ID="Tabs" runat="server" ActiveTabIndex="0" Height="381px"
            Width="100%">
            <TabPages>
                <dxtc:TabPage Name="tpParametros" Text="Par&#225;metros">
                    <ContentCollection>
                        <dxw:ContentControl runat="server">
                            <table id="tabParametros" style="width: 95%; height: 1px" runat=server>
                                <tr runat="server">
                                    <td align="center" style="width: 473px; color: white; height: 16px; background-color: gray" runat="server">
                                        Parámetro</td>
                                    <td align="center" style="text-align: center; color: white; height: 16px; background-color: gray;" runat="server">
                                        Valor</td>
                                </tr>
                            </table>
                            <br />
                            <dxe:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton">
                            </dxe:ASPxButton>
                        </dxw:ContentControl>
                    </ContentCollection>
                </dxtc:TabPage>
                <dxtc:TabPage Name="tpResultados" Text="Resultados">
                    <ContentCollection>
                        <dxw:ContentControl runat="server">
                            <dxwgv:ASPxGridView ID="gvwMain" runat="server" Width="95%">
                                <Settings ShowFilterRow="True" ShowGroupPanel="True" />
                                <SettingsText EmptyDataRow="No hay datos para mostrar" GroupPanel="Arrastre un encabezado de columna para agrupar elementos..." />
                                <SettingsLoadingPanel Text="Cargando&amp;hellip;" />
                            </dxwgv:ASPxGridView>
                        </dxw:ContentControl>
                    </ContentCollection>
                </dxtc:TabPage>
                <dxtc:TabPage Name="tpCubo" Text="Tabla din&#225;mica y cubo">
                    <ContentCollection>
                        <dxw:ContentControl runat="server">
                            <dxwpg:ASPxPivotGrid ID="oCube" runat="server" CssClass="" Width="97%">
                            </dxwpg:ASPxPivotGrid>
                            <br />
                            <br />
                            <dxchartsui:webchartcontrol id="oChart" runat="server" diagramtypename="XYDiagram"
                                Height="243px" Width="299px" PaletteName="Apex" Visible="False">
<Diagram>
<AxisX VisibleInPanesSerializable="-1">
<Range SideMarginsEnabled="True"></Range>
</AxisX>

<AxisY VisibleInPanesSerializable="-1">
<Range SideMarginsEnabled="True"></Range>
</AxisY>
</Diagram>

<FillStyle FillOptionsTypeName="SolidFillOptions">
<Options HiddenSerializableString="to be serialized"></Options>
</FillStyle>
<SeriesSerializable>
<cc1:Series Name="Series 1" LabelTypeName="StackedBarSeriesLabel" PointOptionsTypeName="PointOptions" SeriesViewTypeName="StackedBarSeriesView">
<View HiddenSerializableString="to be serialized"></View>

<Label HiddenSerializableString="to be serialized" OverlappingOptionsTypeName="OverlappingOptions">
<FillStyle FillOptionsTypeName="SolidFillOptions">
<Options HiddenSerializableString="to be serialized"></Options>
</FillStyle>
</Label>

<PointOptions HiddenSerializableString="to be serialized"></PointOptions>

<LegendPointOptions HiddenSerializableString="to be serialized"></LegendPointOptions>
</cc1:Series>
</SeriesSerializable>

<SeriesTemplate LabelTypeName="SideBySideBarSeriesLabel" PointOptionsTypeName="PointOptions" SeriesViewTypeName="SideBySideBarSeriesView">
<View HiddenSerializableString="to be serialized"></View>

<Label HiddenSerializableString="to be serialized" OverlappingOptionsTypeName="OverlappingOptions">
<FillStyle FillOptionsTypeName="SolidFillOptions">
<Options HiddenSerializableString="to be serialized"></Options>
</FillStyle>
</Label>

<PointOptions HiddenSerializableString="to be serialized"></PointOptions>

<LegendPointOptions HiddenSerializableString="to be serialized"></LegendPointOptions>
</SeriesTemplate>
</dxchartsui:webchartcontrol>
                        </dxw:ContentControl>
                    </ContentCollection>
                </dxtc:TabPage>
                <dxtc:TabPage Name="tpInformes" Text="Informes">
                    <ContentCollection>
                        <dxw:ContentControl runat="server">
                        </dxw:ContentControl>
                    </ContentCollection>
                </dxtc:TabPage>
            </TabPages>
        </dxtc:ASPxPageControl>
    
    </div>
    </form>
</body>
</html>
