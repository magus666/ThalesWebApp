Public Class Home
    Inherits System.Web.UI.Page
    Dim GetEmployeeClass As New Cl_Employee

    Protected Async Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                Await FillDataGridAllEmployees()
                Await GetDropDownEmployee()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Async Function FillDataGridAllEmployees() As Threading.Tasks.Task
        Try
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployee
            GrwEmployee.DataSource = GetAllEmployee
            GrwEmployee.DataBind()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function
    Public Async Function FillDataGridEmployeeById() As Threading.Tasks.Task
        Try
            Dim IdEmployeeDropDownList = DdlEmployee.SelectedValue
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployeById(IdEmployeeDropDownList)
            GrwEmployee.DataSource = GetAllEmployee
            GrwEmployee.DataBind()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Function
    Public Async Function GetDropDownEmployee() As Threading.Tasks.Task
        Try
            Dim GetAllEmployee = Await GetEmployeeClass.GetEmployee


            Dim EmployeeName = From EmployeeModel In GetAllEmployee
                               Select EmployeeModel.NameEmployee,
                               EmployeeModel.IdEmployee

            DdlEmployee.DataSource = EmployeeName
            DdlEmployee.DataValueField = "IdEmployee"
            DdlEmployee.DataTextField = "NameEmployee"
            DdlEmployee.DataBind()
            DdlEmployee.Items.Insert(0, "--Select--")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Function

    Protected Async Sub DdlEmployee_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If DdlEmployee.SelectedValue = "--Select--" Then
                Await FillDataGridAllEmployees()
            Else
                Await FillDataGridEmployeeById()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class