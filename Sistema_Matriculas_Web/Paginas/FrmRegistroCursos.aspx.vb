Public Class FrmRegistroCursos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intAccion As Short = CShort(Request.QueryString("accion"))
        Dim intCodigo As Integer = CInt(Request.QueryString("codigo"))
        ViewState("accion") = intAccion

        If Not Page.IsPostBack Then
            Select Case intAccion
                Case 1
                    Me.LblTitulo.Text = "Registrar Carrera"
                    Me.BtnPrueba.Text = "Registrar"

                Case 2
                    Me.LblTitulo.Text = "Modificar Carrera"
                    Me.BtnPrueba.Text = "Modificar"
                    Me.Leer(intCodigo)
                Case 3
                    Me.LblTitulo.Text = "Eliminar Carrera"
                    Me.BtnPrueba.Text = "Eliminar"
                    Me.Leer(intCodigo)
            End Select
        End If
    End Sub

    Protected Sub BtnPrueba_click(sender As Object, e As EventArgs) Handles BtnPrueba.Click
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

                Dim iInfoCarrera As New Entidades.EntiCursos With {
                .Carrera = Me.TxtCarrera.Text.Trim,
                .Id = CInt(TxtId.Text),
                .Nombre = Me.TxtNombre.Text,
                .Creditos = CInt(TxtCreditos.Text),
                .Nota_minima = CInt(TxtNotaMinima.Text),
                .Estudiantes_Min = CInt(TxtEstudianteMin.Text),
                .Estudiantes_Max = CInt(TxtEstudiantesMax.Text),
                .Grado = Me.TxtGrado.Text.Trim,
                .Estado = Me.TxtEstado.Text.Trim
            }

                Dim iCarrera As New Negocios.NegCursos
                iCarrera.GrabarNEg(iInfoCarrera, eAccion)

            End If

        Catch ex As Exception
            Session("Error") = ex
        End Try
    End Sub




    Public Sub Leer(ByVal idCarrera As Integer)
        Dim iCarrera As New Negocios.NegCursos
        Dim iInfoCarrera As Entidades.EntiCursos = iCarrera.Cursos(idCarrera)

        Me.TxtId.ReadOnly = True
        Me.TxtCarrera.ReadOnly = True
        Me.TxtCosto.ReadOnly = True

        If iCarrera IsNot Nothing Then
            Me.TxtCarrera.Text = iInfoCarrera.Carrera
            Me.TxtId.Text = iInfoCarrera.Id
            Me.TxtNombre.Text = iInfoCarrera.Nombre
            Me.TxtCreditos.Text = iInfoCarrera.Creditos
            Me.TxtNotaMinima.Text = iInfoCarrera.Nota_minima
            Me.TxtEstudianteMin.Text = iInfoCarrera.Estudiantes_Min
            Me.TxtEstudiantesMax.Text = iInfoCarrera.Estudiantes_Max
            Me.TxtGrado.Text = iInfoCarrera.Grado
            Me.TxtEstado.Text = iInfoCarrera.Estado
            Me.TxtCosto.Text = iInfoCarrera.Costo
            'Else
            '    Me.lblMensaje.Visible = True
            '    Me.lblMensaje.InnerText = "La carrera selecciona no pose informacion en la base de datos. Verificar"

        End If

    End Sub


End Class