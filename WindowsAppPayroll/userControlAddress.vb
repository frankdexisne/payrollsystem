Public Class userControlAddress
    Protected regionsAdapter As New DataSet1TableAdapters.regionsTableAdapter
    Protected provincesAdapter As New DataSet1TableAdapters.provincesTableAdapter
    Protected citiesAdapter As New DataSet1TableAdapters.citiesTableAdapter
    Protected barangaysAdapter As New DataSet1TableAdapters.barangaysTableAdapter
    Protected addressesAdapter As New DataSet1TableAdapters.addressesTableAdapter

    Public regionsDataTable As New DataSet1.regionsDataTable
    Public provincesDataTable As New DataSet1.provincesDataTable

    Public regionErrorProvider, provinceErrorProvider, cityErrorProvider, barangayErrorProvider, streetErrorProvider, othersErrorProvider As New ErrorProvider

    Public Sub getData(ByVal id As Integer, ByVal sender As Object, ByVal e As EventArgs)
        Dim data As DataSet1.barangaysRow = barangaysAdapter.GetDataById(id).Rows(0)
        cboRegion.SelectedValue = data.Item("region_id")
        Me.cboRegion_SelectionChangeCommitted(sender, e)
        cboProvince.SelectedValue = data.Item("province_id")
        Me.cboProvince_SelectionChangeCommitted(sender, e)
        cboCity.SelectedValue = data.Item("city_id")
        Me.cboCity_SelectionChangeCommitted(sender, e)
        cboBarangay.SelectedValue = id
    End Sub

    Public Sub ResetInputs()
        cboRegion.SelectedIndex = -1
        cboProvince.DataSource = Nothing
        cboProvince.SelectedIndex = -1
        cboCity.DataSource = Nothing
        cboCity.SelectedIndex = -1
        cboBarangay.DataSource = Nothing
        cboBarangay.SelectedIndex = -1
        txtStreet.Clear()
        txtOthers.Clear()
    End Sub

    Public Sub loadData()
        Me.SetDataSource(cboRegion, regionsAdapter.GetData(), "region_id")
        cboRegion.SelectedIndex = -1
    End Sub

    Sub SetDataSource(ByVal cbo As MetroFramework.Controls.MetroComboBox, ByVal dtable As DataTable, ByVal valueMember As String)
        cbo.DataSource = dtable
        cbo.DisplayMember = "name"
        cbo.ValueMember = valueMember
    End Sub

    Public Function isValidInputs() As Boolean
        Dim result As Boolean = True
        If cboRegion.SelectedValue Is Nothing Then
            regionErrorProvider.SetError(cboRegion, "Please select region")
            result = False
        End If
        If cboProvince.SelectedValue Is Nothing Then
            provinceErrorProvider.SetError(cboProvince, "Please select province")
            result = False
        End If
        If cboCity.SelectedValue Is Nothing Then
            regionErrorProvider.SetError(cboCity, "Please select city/municipality")
            result = False
        End If
        If cboBarangay.SelectedValue Is Nothing Then
            regionErrorProvider.SetError(cboBarangay, "Please select barangay")
            result = False
        End If
        Return result
    End Function

    Private Sub cboRegion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRegion.SelectionChangeCommitted
        Me.SetDataSource(cboProvince, provincesAdapter.GetDataByRegionId(cboRegion.SelectedValue), "province_id")
        cboProvince.SelectedIndex = -1
    End Sub

    Private Sub cboProvince_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboProvince.SelectionChangeCommitted
        Me.SetDataSource(cboCity, citiesAdapter.GetDataByProvinceId(cboProvince.SelectedValue), "city_id")
        cboCity.SelectedIndex = -1
    End Sub

    Private Sub cboCity_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCity.SelectionChangeCommitted
        Me.SetDataSource(cboBarangay, barangaysAdapter.GetDataByCityId(cboCity.SelectedValue), "id")
        cboBarangay.SelectedIndex = -1
    End Sub

    Public Sub onSave(ByVal employeeId As Integer, ByVal type As String)
        If Not cboBarangay.SelectedValue Is Nothing Then
            addressesAdapter.InsertQuery(employeeId, cboBarangay.SelectedValue, type, txtStreet.Text, txtOthers.Text)
        End If
    End Sub

End Class
