Public Class Form1
    Public Event CustomerArrived(trigger As String)
    Public Event PriceAsked(trigger As String)
    Public Event PriceNegotiated(trigger As String)
    Public Event PaymentMade(trigger As String)
    Public Event StockUpdated(trigger As String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler CustomerArrived, AddressOf HandleCustomerArrived
        AddHandler PriceAsked, AddressOf HandlePriceAsked
        AddHandler PriceNegotiated, AddressOf HandlePriceNegotiated
        AddHandler PaymentMade, AddressOf HandlePaymentMade
        AddHandler StockUpdated, AddressOf HandleStockUpdated
        lstLog.Items.Add("TIME     | EVENT NAME         | TRIGGER")
        lstLog.Items.Add("-------------------------------------------")

        btnAskPrice.Enabled = False
        btnBargain.Enabled = False
        btnBuy.Enabled = False
        btnStock.Enabled = True
    End Sub

    Private Sub HandleCustomerArrived(trigger As String)
        lblStatus.Text = "Customer has arrived"
        LogEvent("CustomerArrived", trigger)

        btnAskPrice.Enabled = True
    End Sub

    Private Sub HandlePriceAsked(trigger As String)
        lblStatus.Text = "Customer asked for price"
        LogEvent("PriceAsked", trigger)

        btnBargain.Enabled = True
    End Sub

    Private Sub HandlePriceNegotiated(trigger As String)
        lblStatus.Text = "Price negotiated"
        LogEvent("PriceNegotiated", trigger)

        btnBuy.Enabled = True
    End Sub

    Private Sub HandlePaymentMade(trigger As String)
        lblStatus.Text = "Payment made"
        LogEvent("PaymentMade", trigger)

        btnAskPrice.Enabled = False
        btnBargain.Enabled = False
        btnBuy.Enabled = False
    End Sub

    Private Sub HandleStockUpdated(trigger As String)
        lblStatus.Text = "Stock updated"
        LogEvent("StockUpdated", trigger)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBargain.Click
        RaiseEvent PriceNegotiated("Button Click")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        RaiseEvent PaymentMade("Button Click")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        RaiseEvent StockUpdated("Button Click")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAskPrice.Click
        RaiseEvent PriceAsked("Button Click")
    End Sub

    Private Sub btnArrive_Click(sender As Object, e As EventArgs) Handles btnArrive.Click
        RaiseEvent CustomerArrived("Button Click")
    End Sub


    Private Sub LogEvent(eventName As String, trigger As String)
        lstLog.Items.Add($"{DateTime.Now:HH:mm} | {eventName,-18} | {trigger}")
    End Sub


    Private Sub lstLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLog.SelectedIndexChanged
        If lstLog.SelectedItem IsNot Nothing Then
            lblStatus.Text = "Selected Log: " & lstLog.SelectedItem.ToString()
        End If
    End Sub

End Class
