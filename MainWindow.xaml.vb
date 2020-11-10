Class MainWindow

    Private Sub TextBoxText_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextBoxText.LostFocus
        TextBoxChanging.Text = Val(TextBoxText.Text)
        If String.IsNullOrEmpty(TextBoxChanging.Text) Then
            TextBoxChanging.Text = "Text per defecte"
        End If
    End Sub

    Private Sub TextBoxAmple_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextBoxAmple.LostFocus
        Dim Ample = Val(TextBoxAmple.Text)
        If Ample < 500 Then
            TextBoxChanging.Width = Val(TextBoxAmple.Text)
        Else
            MsgBox("La amplada sobrepasa la mida maxima")
        End If
    End Sub

    Private Sub TextBoxAlt_LostFocus(sender As Object, e As RoutedEventArgs) Handles TextBoxAlt.LostFocus
        Dim Alt = Val(TextBoxAlt.Text)
        If Alt < 400 Then
            TextBoxChanging.Height = Val(TextBoxAlt.Text)
        Else
            MsgBox("La altura sobrepasa la mida maxima")
        End If
    End Sub

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
        TextBoxChanging.Background = Brushes.White
    End Sub


End Class
