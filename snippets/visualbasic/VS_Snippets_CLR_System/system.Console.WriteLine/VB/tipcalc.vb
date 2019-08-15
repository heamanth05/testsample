' <Snippet1>
Public Class TipCalculator
   Private Const tipRate As Double = 0.18
   
   Public Shared Sub Main()
      System.Environment.ExitCode = Calculator(System.Environment.GetCommandLineArgs())
   End Sub
   
   Public Shared Function Calculator(args() As String) As Integer
      Dim billTotal As Double
      If (args.Length < 2) OrElse (Not Double.TryParse(args(1), billTotal)) Then
         Console.WriteLine("usage: TIPCALC total")
         Return 1
      End If
     
      Dim tip As Double = billTotal * tipRate
      Console.WriteLine()
      Console.WriteLine($"Bill total:{vbTab}{billTotal,8:c}")
      Console.WriteLine($"Tip total/rate:{vbTab}{tip,8:c} ({tipRate:p1})")
      Console.WriteLine("".PadRight(24, "-"c))
      Console.WriteLine($"Grand total:{vbTab}{billTotal + tip,8:c}")
      Return 0
   End Function 
End Class 

'Example Output:
'---------------
' >tipcalc 52.23
' 
' Bill total:       $52.23
' Tip total/rate:    $9.40 (18.0 %)
' ------------------------
' Grand total:      $61.63
' </Snippet1>
