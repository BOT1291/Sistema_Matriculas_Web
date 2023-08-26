Public Class FrmRegistroCarrera
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intAccion As Short = CShort(Request.QueryString("accion"))
        Dim intCodigo As Integer = CInt(Request.QueryString("codigo"))
        ViewState("accion") = intAccion

        If Not Page.IsPostBack Then
            Select Case intAccion
                Case 1
                    Me.LblTitulo.Text = "Registrar Carrera"
                    Me.BtnRegistrar.Text = "Registrar"

                Case 2
                    Me.LblTitulo.Text = "Modificar Carrera"
                    Me.BtnRegistrar.Text = "Modificar"
                    Me.Leer(intCodigo)
                Case 3
                    Me.LblTitulo.Text = "Eliminar Carrera"
                    Me.BtnRegistrar.Text = "Eliminar"
                    Me.Leer(intCodigo)
            End Select
        End If
    End Sub


    Protected Sub BtnRegistrar_click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            Dim intAccion As Short = ViewState("accion")
            Dim eAccion As Entidades.EntiEnumeradores.Accion = Entidades.EntiEnumeradores.Accion.Registrar

            If Page.IsValid Then
                Select Case intAccion
                    Case 1
                        eAccion = Entidades.EntiEnumeradores.Accion.Registrar
                    Case 2
                        eAccion = Entidades.EntiEnumeradores.Accion.Modificar
                    Case 3
                        eAccion = Entidades.EntiEnumeradores.Accion.Borrar
                End Select

                Dim iInfoCarrera As New Entidades.EntiCarrera With {
                .Identificacion = Me.TxtIdentificacion.Text.Trim,
                .Nombre = Me.TxtNombre.Text.Trim,
                .Estado = Me.DDLEstado.Text.Trim
                }

                Dim iCarrera As New Negocios.NegCarrera
                iCarrera.GrabarN(iInfoCarrera, intAccion)

            End If


        Catch ex As Exception
            Session("Error") = ex
        End Try

    End Sub



    Public Sub Leer(ByVal idCarrera As Integer)
        Dim iCarrera As New Negocios.NegCarrera
        Dim iInfoCarrera As Entidades.EntiCarrera = iCarrera.Funcionarios(idCarrera)

        Me.TxtIdentificacion.ReadOnly = True

        If iCarrera IsNot Nothing Then
            Me.TxtIdentificacion.Text = iInfoCarrera.Identificacion
            Me.TxtNombre.Text = iInfoCarrera.Nombre
            Me.DDLEstado.Text = iInfoCarrera.Estado
            'Else
            '    Me.lblMensaje.Visible = True
            '    Me.lblMensaje.InnerText = "La carrera selecciona no pose informacion en la base de datos. Verificar"

        End If

    End Sub

End Class