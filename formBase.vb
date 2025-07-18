Public Class formBase

    Private AllKM As Decimal = 0.0D

    Private Sub btnStartKM_Click(sender As Object, e As EventArgs) Handles btnStartKM.Click
        If nudStartKM.Value >= 0 Then
            AllKM = nudStartKM.Value
            UpdateKMText()
            nudStartKM.Value = 0

            pnlStartKM.Visible = False
            pnlStartKM.Enabled = False

            pnlDonations.Visible = True
            pnlDonations.Enabled = True
            Return
        Else
            MessageBox.Show("Hibás érték a kezdő kilométerben!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error)
            nudStartKM.Focus()
            Return
        End If
    End Sub



    Private Sub AddDistance(type As DonationType, count As Integer)
        Dim meterPerItem As Decimal = GetMetersPerItem(type, AllKM)
        Dim totalMeters As Decimal = meterPerItem * count
        AllKM += totalMeters / 1000.0
        UpdateKMText()
    End Sub

    Private Function GetMetersPerItem(type As DonationType, km As Decimal) As Decimal
        Select Case type
            Case DonationType.Sub
                If km < 5 Then Return 1000.0
                If km < 15 Then Return 600.0
                If km < 20 Then Return 400.0
                If km < 25 Then Return 200.0
                Return 100.0
            Case DonationType.Euro
                If km < 5 Then Return 200.0
                If km < 15 Then Return 125.0
                If km < 20 Then Return 75.0
                If km < 25 Then Return 50.0
                Return 25.0
            Case DonationType.Chest
                If km < 5 Then Return 600.0
                If km < 15 Then Return 400.0
                If km < 20 Then Return 250.0
                If km < 25 Then Return 100.0
                Return 25
            Case DonationType.Bits
                If km < 5 Then Return 2
                If km < 15 Then Return 1.25
                If km < 20 Then Return 0.75
                If km < 25 Then Return 0.5
                Return 0.25
        End Select
        Return 0
    End Function

    Private Sub UpdateKMText()
        lblAllKM.Text = $"{AllKM:N3} km"
    End Sub

    Private Sub btnSLSub_Click(sender As Object, e As EventArgs) Handles btnSLSub.Click
        AddDistance(DonationType.Sub, CInt(nudSLSub.Value))
        nudSLSub.Value = 0
    End Sub

    Private Sub btnLuckyCheck_Click(sender As Object, e As EventArgs) Handles btnLuckyCheck.Click
        AddDistance(DonationType.Chest, CInt(nudLuckyCheck.Value))
        nudLuckyCheck.Value = 0
    End Sub

    Private Sub btnEuro_Click(sender As Object, e As EventArgs) Handles btnEuro.Click
        AddDistance(DonationType.Euro, CInt(nudEuro.Value))
        nudEuro.Value = 0
    End Sub

    Private Sub btnBit_Click(sender As Object, e As EventArgs) Handles btnBit.Click
        AddDistance(DonationType.Bits, CInt(nudBit.Value))
        nudBit.Value = 0
    End Sub

    Private Sub btnOtherAdd_Click(sender As Object, e As EventArgs) Handles btnOtherAdd.Click
        AllKM += nudOther.Value / 1000D
        nudOther.Value = 0
        UpdateKMText()
    End Sub

    Private Sub btnOtherMinus_Click(sender As Object, e As EventArgs) Handles btnOtherMinus.Click
        If nudOther.Value > AllKM * 1000D Then
            MessageBox.Show("Nem lehet több kilométert levonni, mint amennyi eddig összegyűlt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            AllKM -= nudOther.Value / 1000D
            nudOther.Value = 0
            UpdateKMText()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MessageBox.Show("Biztosan visszaállítod a kilométereket?", "Visszaállítás", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AllKM = 0D
            pnlStartKM.Visible = True
            pnlStartKM.Enabled = True

            pnlDonations.Visible = False
            pnlDonations.Enabled = False
            UpdateKMText()
        End If
    End Sub

End Class
