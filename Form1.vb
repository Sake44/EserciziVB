Public Class Form1

    Dim ComputePayment As Boolean

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnNewLoan_Click(sender As Object, e As EventArgs) Handles btnNewLoan.Click

        If ComputePayment Then
            txtPayment.Text = ""
        Else
            txtMonth.Text = ""
        End If

        txtAnalysis.Text = ""
        btnCompute.Enabled = True
        btnNewLoan.Enabled = False
        txtBalance.Focus()


    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        ComputePayment = True
        btnPayment.Visible = False
        btnMonth.Visible = True
        txtMonth.ReadOnly = False
        txtMonth.TabStop = True
        txtMonth.BackColor = Color.White
        txtPayment.Text = ""
        txtPayment.ReadOnly = True
        txtPayment.TabStop = False
        txtPayment.BackColor = Color.LightYellow
        btnCompute.Text = "Calcola Pagamenti Mensili"
        txtBalance.Focus()


    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click

        ComputePayment = False
        btnPayment.Visible = True
        btnMonth.Visible = False
        txtMonth.ReadOnly = True
        txtMonth.TabStop = False
        txtMonth.BackColor = Color.LightYellow
        txtMonth.Text = ""
        txtPayment.ReadOnly = False
        txtPayment.TabStop = True
        txtPayment.BackColor = Color.White
        btnCompute.Text = "Calcola Numero Pagamenti"
        txtBalance.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnPayment.PerformClick()

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click

        Dim Balance As Double
        Dim Interest As Double
        Dim Months As Integer
        Dim Payment As Double
        Dim MonthlyInt As Double
        Dim Multiplier As Double
        'create three var. to generate loan analysis (text box below "Analisi Prestiti")
        Dim loanBalance As Double
        Dim FinalPayment As Double
        Dim PaymentNumber As Integer



        Balance = Val(txtBalance.Text)
        Interest = Val(txtInterest.Text)
        MonthlyInt = Interest / 1200 'Interest is an yearly percentage, so convert it in a monthly percentage
        If ComputePayment Then

            'compute loan payment
            Months = Val(txtMonth.Text)
            Multiplier = CDbl((1 + MonthlyInt) ^ Months)
            Payment = Balance * MonthlyInt * Multiplier / (Multiplier - 1)
            txtPayment.Text = Format(Payment, "0.00")

        Else

            'compute number of payments
            Payment = Val(txtPayment.Text)
            Months = CInt((Math.Log(Payment) - Math.Log(Payment - Balance * MonthlyInt)) / Math.Log(1 + MonthlyInt))
            txtMonth.Text = Format(Months, "00")

        End If

        Payment = Val(txtPayment.Text)
        'show analysis
        txtAnalysis.Text = "Bilancio Prestiti: " + Format(Balance, "$0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Interesse: " + Format(Interest, "0.00") + "%"
        loanBalance = Balance
        For PaymentNumber = 1 To Months - 1
            loanBalance += loanBalance * MonthlyInt - Payment
        Next PaymentNumber
        'find final payment
        FinalPayment = loanBalance
        If FinalPayment > Payment Then
            'apply one more payment
            loanBalance += loanBalance * MonthlyInt - Payment
            FinalPayment = loanBalance
            Months += 1
            txtMonth.Text = Format(Months, "00")
        End If
        txtAnalysis.Text += ControlChars.CrLf + "Pagamento Intressi di: " + Format(FinalPayment, "$0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Pagamento Totale: " + Format((Months - 1) * Payment + FinalPayment, "$0.00")
        txtAnalysis.Text += ControlChars.CrLf + "Interessi Pagati: " + Format((Months - 1) * Payment + FinalPayment - Balance, "$0.00")
        btnCompute.Enabled = False
        btnNewLoan.Enabled = True
        btnNewLoan.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
