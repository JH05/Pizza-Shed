Public Class Form1
    Dim Total As Double
    Private Sub ON1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON1.Click
        'Customer #1
        TableNumber1.Visible = True
        TableNumber2.Visible = False
        TableNumber3.Visible = False
        TableNumber4.Visible = False
        TableNumber5.Visible = False

        Toppings1.Visible = True
        Toppings2.Visible = False
        Toppings3.Visible = False
        Toppings4.Visible = False
        Toppings5.Visible = False

        Pizza1.Visible = True
        Pizza2.Visible = False
        Pizza3.Visible = False
        Pizza4.Visible = False
        Pizza5.Visible = False

        PizzaBase1.Visible = True
        PizzaBase2.Visible = False
        PizzaBase3.Visible = False
        PizzaBase4.Visible = False
        PizzaBase5.Visible = False

        Drinks1.Visible = True
        Drinks2.Visible = False
        Drinks3.Visible = False
        Drinks4.Visible = False
        Drinks5.Visible = False

        lblPizza1.Visible = True
        lblPizza2.Visible = False
        lblPizza3.Visible = False
        lblPizza4.Visible = False
        lblPizza5.Visible = False

        lblToppings1.Visible = True
        lblToppings2.Visible = False
        lblToppings3.Visible = False
        lblToppings4.Visible = False
        lblToppings5.Visible = False

        lblDrinks1.Visible = True
        lblDrinks2.Visible = False
        lblDrinks3.Visible = False
        lblDrinks4.Visible = False
        lblDrinks5.Visible = False

        If ExtraCheese1.CheckState = 1 Then
        ElseIf Pepperoni1.CheckState = 1 Then
        ElseIf Onions1.CheckState = 1 Then
        ElseIf Peppers1.CheckState = 1 Then
        End If

        If Cola1.Checked = True Then
        ElseIf Lemonade1.Checked = True Then
        ElseIf FizzyOrange1.Checked = True Then
        End If

    End Sub

    Private Sub ON2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON2.Click
        'Customer #2

        TableNumber1.Visible = False
        TableNumber2.Visible = True
        TableNumber3.Visible = False
        TableNumber4.Visible = False
        TableNumber5.Visible = False

        Toppings1.Visible = False
        Toppings2.Visible = True
        Toppings3.Visible = False
        Toppings4.Visible = False
        Toppings5.Visible = False

        Pizza1.Visible = False
        Pizza2.Visible = True
        Pizza3.Visible = False
        Pizza4.Visible = False
        Pizza5.Visible = False

        PizzaBase1.Visible = False
        PizzaBase2.Visible = True
        PizzaBase3.Visible = False
        PizzaBase4.Visible = False
        PizzaBase5.Visible = False

        Drinks1.Visible = False
        Drinks2.Visible = True
        Drinks3.Visible = False
        Drinks4.Visible = False
        Drinks5.Visible = False

        lblPizza1.Visible = False
        lblPizza2.Visible = True
        lblPizza3.Visible = False
        lblPizza4.Visible = False
        lblPizza5.Visible = False

        lblToppings1.Visible = False
        lblToppings2.Visible = True
        lblToppings3.Visible = False
        lblToppings4.Visible = False
        lblToppings5.Visible = False

        lblDrinks1.Visible = False
        lblDrinks2.Visible = True
        lblDrinks3.Visible = False
        lblDrinks4.Visible = False
        lblDrinks5.Visible = False

        If ExtraCheese2.CheckState = 1 Then
        ElseIf Pepperoni2.CheckState = 1 Then
        ElseIf Onions2.CheckState = 1 Then
        ElseIf Peppers2.CheckState = 1 Then
        End If

        If Cola2.Checked = True Then
        ElseIf Lemonade2.Checked = True Then
        ElseIf FizzyOrange2.Checked = True Then
        End If

    End Sub

    Private Sub ON3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON3.Click
        'Customer #3

        TableNumber1.Visible = False
        TableNumber2.Visible = False
        TableNumber3.Visible = True
        TableNumber4.Visible = False
        TableNumber5.Visible = False

        Toppings1.Visible = False
        Toppings2.Visible = False
        Toppings3.Visible = True
        Toppings4.Visible = False
        Toppings5.Visible = False

        Pizza1.Visible = False
        Pizza2.Visible = False
        Pizza3.Visible = True
        Pizza4.Visible = False
        Pizza5.Visible = False

        PizzaBase1.Visible = False
        PizzaBase2.Visible = False
        PizzaBase3.Visible = True
        PizzaBase4.Visible = False
        PizzaBase5.Visible = False

        Drinks1.Visible = False
        Drinks2.Visible = False
        Drinks3.Visible = True
        Drinks4.Visible = False
        Drinks5.Visible = False

        lblPizza1.Visible = False
        lblPizza2.Visible = False
        lblPizza3.Visible = True
        lblPizza4.Visible = False
        lblPizza5.Visible = False

        lblToppings1.Visible = False
        lblToppings2.Visible = False
        lblToppings3.Visible = True
        lblToppings4.Visible = False
        lblToppings5.Visible = False

        lblDrinks1.Visible = False
        lblDrinks2.Visible = False
        lblDrinks3.Visible = True
        lblDrinks4.Visible = False
        lblDrinks5.Visible = False

        If ExtraCheese3.CheckState = 1 Then
        ElseIf Pepperoni3.CheckState = 1 Then
        ElseIf Onions3.CheckState = 1 Then
        ElseIf Peppers3.CheckState = 1 Then
        End If

        If Cola3.Checked = True Then
        ElseIf Lemonade3.Checked = True Then
        ElseIf FizzyOrange3.Checked = True Then
        End If

    End Sub

    Private Sub ON4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON4.Click
        'Customer #4

        TableNumber1.Visible = False
        TableNumber2.Visible = False
        TableNumber3.Visible = False
        TableNumber4.Visible = True
        TableNumber5.Visible = False

        Toppings1.Visible = False
        Toppings2.Visible = False
        Toppings3.Visible = False
        Toppings4.Visible = True
        Toppings5.Visible = False

        Pizza1.Visible = False
        Pizza2.Visible = False
        Pizza3.Visible = False
        Pizza4.Visible = True
        Pizza5.Visible = False

        PizzaBase1.Visible = False
        PizzaBase2.Visible = False
        PizzaBase3.Visible = False
        PizzaBase4.Visible = True
        PizzaBase5.Visible = False

        Drinks1.Visible = False
        Drinks2.Visible = False
        Drinks3.Visible = False
        Drinks4.Visible = True
        Drinks5.Visible = False

        lblPizza1.Visible = False
        lblPizza2.Visible = False
        lblPizza3.Visible = False
        lblPizza4.Visible = True
        lblPizza5.Visible = False

        lblToppings1.Visible = False
        lblToppings2.Visible = False
        lblToppings3.Visible = False
        lblToppings4.Visible = True
        lblToppings5.Visible = False

        lblDrinks1.Visible = False
        lblDrinks2.Visible = False
        lblDrinks3.Visible = False
        lblDrinks4.Visible = True
        lblDrinks5.Visible = False

        If ExtraCheese4.CheckState = 1 Then
        ElseIf Pepperoni4.CheckState = 1 Then
        ElseIf Onions4.CheckState = 1 Then
        ElseIf Peppers4.CheckState = 1 Then
        End If

        If Cola4.Checked = True Then
        ElseIf Lemonade4.Checked = True Then
        ElseIf FizzyOrange4.Checked = True Then
        End If

    End Sub

    Private Sub ON5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ON5.Click
        'Customer #5

        TableNumber1.Visible = False
        TableNumber2.Visible = False
        TableNumber3.Visible = False
        TableNumber4.Visible = False
        TableNumber5.Visible = True

        Toppings1.Visible = False
        Toppings2.Visible = False
        Toppings3.Visible = False
        Toppings4.Visible = False
        Toppings5.Visible = True

        Pizza1.Visible = False
        Pizza2.Visible = False
        Pizza3.Visible = False
        Pizza4.Visible = False
        Pizza5.Visible = True

        PizzaBase1.Visible = False
        PizzaBase2.Visible = False
        PizzaBase3.Visible = False
        PizzaBase4.Visible = False
        PizzaBase5.Visible = True

        Drinks1.Visible = False
        Drinks2.Visible = False
        Drinks3.Visible = False
        Drinks4.Visible = False
        Drinks5.Visible = True

        lblPizza1.Visible = False
        lblPizza2.Visible = False
        lblPizza3.Visible = False
        lblPizza4.Visible = False
        lblPizza5.Visible = True

        lblToppings1.Visible = False
        lblToppings2.Visible = False
        lblToppings3.Visible = False
        lblToppings4.Visible = False
        lblToppings5.Visible = True

        lblDrinks1.Visible = False
        lblDrinks2.Visible = False
        lblDrinks3.Visible = False
        lblDrinks4.Visible = False
        lblDrinks5.Visible = True

        If ExtraCheese5.CheckState = 1 Then
        ElseIf Pepperoni5.CheckState = 1 Then
        ElseIf Onions5.CheckState = 1 Then
        ElseIf Peppers5.CheckState = 1 Then
        End If

        If Cola5.Checked = True Then
        ElseIf Lemonade5.Checked = True Then
        ElseIf FizzyOrange5.Checked = True Then
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form
        Dim TableNumber As Single
        Dim Pizza As Single
        Dim PizzaBase As Single
        Dim Drinks As Single
        Dim Requests As Single

        TableNumber = TableNumber
        Pizza = Pizza
        PizzaBase = PizzaBase
        Drinks = Drinks
        Requests = Requests

        Toppings2.Visible = False
        Toppings3.Visible = False

        TableNumber2.Visible = False
        TableNumber3.Visible = False
        TableNumber4.Visible = False
        TableNumber5.Visible = False

        PizzaBase2.Visible = False
        PizzaBase3.Visible = False
        PizzaBase4.Visible = False
        PizzaBase5.Visible = False

        Pizza2.Visible = False
        Pizza3.Visible = False
        Pizza4.Visible = False
        Pizza5.Visible = False

        Drinks2.Visible = False
        Drinks3.Visible = False
        Drinks4.Visible = False
        Drinks5.Visible = False

        lblPizza2.Visible = False
        lblPizza3.Visible = False
        lblPizza4.Visible = False
        lblPizza5.Visible = False

        lblToppings2.Visible = False
        lblToppings3.Visible = False
        lblToppings4.Visible = False
        lblToppings5.Visible = False

        lblDrinks2.Visible = False
        lblDrinks3.Visible = False
        lblDrinks4.Visible = False
        lblDrinks5.Visible = False

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Total = Val(Total) + #
        'Pizza
        ' ------- #1 ------- '
        If Pizza1.Text = "Cheese and Tomato" Then
            lblPizza1.Text = "3.50"
            Total = Val(Total) + 3.5
        ElseIf Pizza1.Text = "Ham and Pineapple" Then
            lblPizza1.Text = "4.20"
            Total = Val(Total) + 4.2
        ElseIf Pizza1.Text = "Vegetarian" Then
            lblPizza1.Text = "5.20"
            Total = Val(Total) + 5.2
        ElseIf Pizza1.Text = "Meat Feast" Then
            lblPizza1.Text = "5.80"
            Total = Val(Total) + 5.8
        ElseIf Pizza1.Text = "Seafood" Then
            lblPizza1.Text = "5.60"
            Total = Val(Total) + 5.6
        End If
        ' ------- #2 ------- '
        If Pizza2.Text = "Cheese and Tomato" Then
            lblPizza2.Text = "3.50"
            Total = Val(Total) + 3.5
        ElseIf Pizza2.Text = "Ham and Pineapple" Then
            lblPizza2.Text = "4.20"
            Total = Val(Total) + 4.2
        ElseIf Pizza2.Text = "Vegetarian" Then
            lblPizza2.Text = "5.20"
            Total = Val(Total) + 5.2
        ElseIf Pizza2.Text = "Meat Feast" Then
            lblPizza2.Text = "5.80"
            Total = Val(Total) + 5.8
        ElseIf Pizza2.Text = "Seafood" Then
            lblPizza2.Text = "5.60"
            Total = Val(Total) + 5.6
        End If
        ' ------- #3 ------- '
        If Pizza3.Text = "Cheese and Tomato" Then
            lblPizza3.Text = "3.50"
            Total = Val(Total) + 3.5
        ElseIf Pizza3.Text = "Ham and Pineapple" Then
            lblPizza3.Text = "4.20"
            Total = Val(Total) + 4.2
        ElseIf Pizza3.Text = "Vegetarian" Then
            lblPizza3.Text = "5.20"
            Total = Val(Total) + 5.2
        ElseIf Pizza3.Text = "Meat Feast" Then
            lblPizza3.Text = "5.80"
            Total = Val(Total) + 5.8
        ElseIf Pizza3.Text = "Seafood" Then
            lblPizza3.Text = "5.60"
            Total = Val(Total) + 5.6
        End If
        ' ------- #4 ------- '
        If Pizza4.Text = "Cheese and Tomato" Then
            lblPizza4.Text = "3.50"
            Total = Val(Total) + 3.4
        ElseIf Pizza4.Text = "Ham and Pineapple" Then
            lblPizza4.Text = "4.20"
            Total = Val(Total) + 4.2
        ElseIf Pizza4.Text = "Vegetarian" Then
            lblPizza4.Text = "5.20"
            Total = Val(Total) + 5.2
        ElseIf Pizza4.Text = "Meat Feast" Then
            lblPizza4.Text = "5.80"
            Total = Val(Total) + 5.8
        ElseIf Pizza4.Text = "Seafood" Then
            lblPizza4.Text = "5.60"
            Total = Val(Total) + 5.6
        End If
        ' ------- #5 ------- '
        If Pizza5.Text = "Cheese and Tomato" Then
            lblPizza5.Text = "3.50"
            Total = Val(Total) + 3.5
        ElseIf Pizza5.Text = "Ham and Pineapple" Then
            lblPizza5.Text = "4.20"
            Total = Val(Total) + 4.2
        ElseIf Pizza5.Text = "Vegetarian" Then
            lblPizza5.Text = "5.20"
            Total = Val(Total) + 5.2
        ElseIf Pizza5.Text = "Meat Feast" Then
            lblPizza5.Text = "5.80"
            Total = Val(Total) + 5.8
        ElseIf Pizza5.Text = "Seafood" Then
            lblPizza5.Text = "5.60"
            Total = Val(Total) + 5.6
        End If

        'Toppings
        ' ------- #1 ------- '
        If ExtraCheese1.Checked = True Then
            lblToppings1.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Pepperoni1.Checked = True Then
            lblToppings1.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Onions1.Checked = True Then
            lblToppings1.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Peppers1.Checked = True Then
            lblToppings1.Text = "0.50"
            Total = Val(Total) + 0.5
        End If
        ' ------- #2 ------- '
        If ExtraCheese2.Checked = True Then
            lblToppings2.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Pepperoni2.Checked = True Then
            lblToppings2.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Onions2.Checked = True Then
            lblToppings2.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Peppers2.Checked = True Then
            lblToppings2.Text = "0.50"
            Total = Val(Total) + 0.5
        End If
        ' ------- #3 ------- '
        If ExtraCheese3.Checked = True Then
            lblToppings3.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Pepperoni3.Checked = True Then
            lblToppings3.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Onions3.Checked = True Then
            lblToppings3.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Peppers3.Checked = True Then
            lblToppings3.Text = "0.50"
            Total = Val(Total) + 0.5
        End If
        ' ------- #4 ------- '
        If ExtraCheese4.Checked = True Then
            lblToppings4.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Pepperoni4.Checked = True Then
            lblToppings4.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Onions4.Checked = True Then
            lblToppings4.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Peppers4.Checked = True Then
            lblToppings4.Text = "0.50"
            Total = Val(Total) + 0.5
        End If
        ' ------- #5 ------- '
        If ExtraCheese5.Checked = True Then
            lblToppings5.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Pepperoni5.Checked = True Then
            lblToppings5.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Onions5.Checked = True Then
            lblToppings5.Text = "0.50"
            Total = Val(Total) + 0.5
        ElseIf Peppers5.Checked = True Then
            lblToppings5.Text = "0.50"
            Total = Val(Total) + 0.5
        End If

        'Drinks
        ' ------- #1 ------- '
        If Cola1.Checked = True Then
            lblDrinks1.Text = "0.90"
            Total = Val(Total) + 0.9
        ElseIf Lemonade1.Checked = True Then
            lblDrinks1.Text = "0.80"
            Total = Val(Total) + 0.8
        ElseIf FizzyOrange1.Checked = True Then
            lblDrinks1.Text = "0.90"
            Total = Val(Total) + 0.9
        End If
        ' ------- #2 ------- 
        If Cola2.Checked = True Then
            lblDrinks2.Text = "0.90"
            Total = Val(Total) + 0.9
        ElseIf Lemonade2.Checked = True Then
            lblDrinks2.Text = "0.80"
            Total = Val(Total) + 0.8
        ElseIf FizzyOrange2.Checked = True Then
            lblDrinks2.Text = "0.90"
            Total = Val(Total) + 0.9
        End If
        ' ------- #3 ------- '
        If Cola3.Checked = True Then
            lblDrinks3.Text = "0.90"
            Total = Val(Total) + 0.9
        ElseIf Lemonade3.Checked = True Then
            lblDrinks3.Text = "0.80"
            Total = Val(Total) + 0.8
        ElseIf FizzyOrange3.Checked = True Then
            lblDrinks3.Text = "0.90"
            Total = Val(Total) + 0.9
        End If
        ' ------- #4 ------- '
        If Cola4.Checked = True Then
            lblDrinks4.Text = "0.90"
            Total = Val(Total) + 0.9
        ElseIf Lemonade4.Checked = True Then
            lblDrinks4.Text = "0.80"
            Total = Val(Total) + 0.8
        ElseIf FizzyOrange1.Checked = True Then
            lblDrinks4.Text = "0.90"
            Total = Val(Total) + 0.9
        End If
        ' ------- #5 ------- '
        If Cola5.Checked = True Then
            lblDrinks5.Text = "0.90"
            Total = Val(Total) + 0.9
        ElseIf Lemonade5.Checked = True Then
            lblDrinks5.Text = "0.80"
            Total = Val(Total) + 0.8
        ElseIf FizzyOrange5.Checked = True Then
            lblDrinks5.Text = "0.90"
            Total = Val(Total) + 0.9
        End If

        'Total Price
        lblPriceTotal.Text = Format(Total, "Currency")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHelp.Click
        'Help Button
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        'Clears Combo Boxes
        TableNumber1.Text = "Table Number"
        Pizza1.Text = "Select Pizza"
        PizzaBase1.Text = "Select Pizza Base"
        ' ------- #2 ------- '
        TableNumber2.Text = "Table Number"
        Pizza2.Text = "Select Pizza"
        PizzaBase2.Text = "Select Pizza Base"
        ' ------- #3 ------- '
        TableNumber3.Text = "Table Number"
        Pizza3.Text = "Select Pizza"
        PizzaBase3.Text = "Select Pizza Base"
        ' ------- #4 ------- '
        TableNumber4.Text = "Table Number"
        Pizza4.Text = "Select Pizza"
        PizzaBase4.Text = "Select Pizza Base"
        ' ------- #5 ------- '
        TableNumber5.Text = "Table Number"
        Pizza5.Text = "Select Pizza"
        PizzaBase5.Text = "Select Pizza Base"

        'Makes toppings Visible
        Toppings1.Visible = True
        Toppings2.Visible = True
        Toppings3.Visible = True
        Toppings4.Visible = True
        Toppings5.Visible = True

        'Clears Selected Toppings
        ' ------- #1 ------- '
        ExtraCheese1.Checked = False
        Pepperoni1.Checked = False
        Onions1.Checked = False
        Peppers1.Checked = False
        ' ------- #2 ------- '
        ExtraCheese2.Checked = False
        Pepperoni2.Checked = False
        Onions2.Checked = False
        Peppers2.Checked = False
        ' ------- #3 ------- '
        ExtraCheese3.Checked = False
        Pepperoni3.Checked = False
        Onions3.Checked = False
        Peppers3.Checked = False
        ' ------- #4 ------- '
        ExtraCheese4.Checked = False
        Pepperoni4.Checked = False
        Onions4.Checked = False
        Peppers4.Checked = False
        ' ------- #5 ------- '
        ExtraCheese5.Checked = False
        Pepperoni5.Checked = False
        Onions5.Checked = False
        Peppers5.Checked = False

        'Clears Selected Drinks
        ' ------- #1 ------- '
        Cola1.Checked = False
        Lemonade1.Checked = False
        FizzyOrange1.Checked = False
        ' ------- #2 ------- '
        Cola2.Checked = False
        Lemonade2.Checked = False
        FizzyOrange2.Checked = False
        ' ------- #3 ------- '
        Cola3.Checked = False
        Lemonade3.Checked = False
        FizzyOrange3.Checked = False
        ' ------- #4 ------- '
        Cola4.Checked = False
        Lemonade4.Checked = False
        FizzyOrange4.Checked = False
        ' ------- #5 ------- '
        Cola5.Checked = False
        Lemonade5.Checked = False
        FizzyOrange5.Checked = False

        lblPizza1.Text = "0.00"
        lblPizza2.Text = "0.00"
        lblPizza3.Text = "0.00"
        lblPizza4.Text = "0.00"
        lblPizza5.Text = "0.00"

        lblToppings1.Text = "0.00"
        lblToppings2.Text = "0.00"
        lblToppings3.Text = "0.00"
        lblToppings4.Text = "0.00"
        lblToppings5.Text = "0.00"

        lblDrinks1.Text = "0.00"
        lblDrinks2.Text = "0.00"
        lblDrinks3.Text = "0.00"
        lblDrinks4.Text = "0.00"
        lblDrinks5.Text = "0.00"

        'Clears Additional Custom Requests
        Requests.Clear()

        'Clears Total Price
        lblPriceTotal.Text = ""

        'Makes Total
        Total = 0

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Exits the program
        End
    End Sub
End Class
