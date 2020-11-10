Class MainWindow

    Private Sub RadioButtonRed_Checked(sender As Object, e As RoutedEventArgs) Handles RadioButtonRed.Checked
        TextBoxChanging.Background = Brushes.Red
    End Sub

    Private Sub RadioButtonGreen_Checked(sender As Object, e As RoutedEventArgs) Handles RadioButtonGreen.Checked
        TextBoxChanging.Background = Brushes.Green
    End Sub

    Private Sub RadioButtonBlue_Checked(sender As Object, e As RoutedEventArgs) Handles RadioButtonBlue.Checked
        TextBoxChanging.Background = Brushes.Blue
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        TextBoxText.Text = "TextBox"
        TextBoxAlt.Text = "TextBox"
        TextBoxAmple.Text = "TextBox"
        TextBoxChanging.Text = "Text per defecte"


    End Sub
End Class
