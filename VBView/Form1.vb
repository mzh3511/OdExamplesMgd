Public Class Form1
  Private dd As Teigha.Runtime.Services
  Private database As Database
  Private graphics As Graphics
  Private helperDevice As Teigha.GraphicsSystem.LayoutHelperDevice

  Public Sub New()
    dd = New Teigha.Runtime.Services()
    InitializeComponent()
  End Sub
  Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
    If (DialogResult.OK = openFileDialog.ShowDialog()) Then
      Dim bLoaded As Boolean = True
      database = New Database(False, False)

      If (openFileDialog.FilterIndex = 1) Then
        Try
          database.ReadDwgFile(openFileDialog.FileName, FileOpenMode.OpenForReadAndAllShare, False, "")
        Catch ex As Exception
          MessageBox.Show(ex.Message)
          bLoaded = False
        End Try
      Else
        Try
          database.DxfIn(openFileDialog.FileName, "")
        Catch ex As Exception
          MessageBox.Show(ex.Message)
          bLoaded = False
        End Try
      End If

      If (bLoaded) Then
        HostApplicationServices.WorkingDatabase = database
        InitializeGraphics()
        Invalidate()
      End If
    End If
  End Sub

  Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    If (Not (graphics Is Nothing)) Then
      graphics.Dispose()
    End If
    If (Not (helperDevice Is Nothing)) Then
      helperDevice.Dispose()
    End If
    If (Not (database Is Nothing)) Then
      database.Dispose()
    End If
    dd.Dispose()
  End Sub
  Private Sub InitializeGraphics()
    Try
      graphics = graphics.FromHwnd(DrawingPanel.Handle)
      Dim gsModule As GsModule
      gsModule = CType(Teigha.Runtime.SystemObjects.DynamicLinker.LoadModule("WinGDI.txv", False, True), GsModule)
      Dim graphichsDevice As Teigha.GraphicsSystem.Device = gsModule.CreateDevice()
      Dim props As Teigha.Runtime.Dictionary = graphichsDevice.Properties
      If props.Contains("WindowHWND") Then
        props.AtPut("WindowHWND", New Teigha.Runtime.RxVariant(CType(DrawingPanel.Handle, Integer)))
      End If
      If props.Contains("WindowHDC") Then
        props.AtPut("WindowHDC", New Teigha.Runtime.RxVariant(CType(graphics.GetHdc(), Integer)))
      End If
      If props.Contains("DoubleBufferEnabled") Then
        props.AtPut("DoubleBufferEnabled", New Teigha.Runtime.RxVariant(True))
      End If
      If props.Contains("EnableSoftwareHLR") Then
        props.AtPut("EnableSoftwareHLR", New Teigha.Runtime.RxVariant(True))
      End If
      If props.Contains("DiscardBackFaces") Then
        props.AtPut("DiscardBackFaces", New Teigha.Runtime.RxVariant(True))
      End If

      Dim ctx As ContextForDbDatabase = New ContextForDbDatabase(database)
      ctx.UseGsModel = True
      helperDevice = LayoutHelperDevice.SetupActiveLayoutViews(graphichsDevice, ctx)
      helperDevice.SetLogicalPalette(Device.DarkPalette)

      ResizeDev()
      helperDevice.Model.Invalidate(InvalidationHint.kInvalidateAll)
    Catch ex As Exception
      MessageBox.Show(ex.ToString())
    End Try
  End Sub

  Private Sub ResizeDev()
    If (Not (helperDevice Is Nothing)) Then
      Dim rect As Rectangle = DrawingPanel.Bounds
      rect.Offset(-DrawingPanel.Location.X, -DrawingPanel.Location.Y)
      'HDC assigned to the device corresponds to the whole client area of the panel
      helperDevice.OnSize(rect)
      Invalidate()
    End If

  End Sub

  Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
    Dim oPage As DWFPageData
    oPage = New DWFPageData()
  End Sub

  Private Sub DrawingPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DrawingPanel.Paint
    If (Not (helperDevice Is Nothing)) Then
      Try
        helperDevice.Update()

      Catch ex As Exception
        graphics.DrawString(ex.ToString(), New Font("Arial", 16), New SolidBrush(Color.Black), New PointF(150.0F, 150.0F))
      End Try
    End If
  End Sub

  Private Sub InsertBlockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertBlockToolStripMenuItem.Click
    If (DialogResult.OK = openFileDialog.ShowDialog()) Then
      Dim blockDb As New Database(False, False)

      Try
        blockDb.ReadDwgFile(openFileDialog.FileName, IO.FileShare.Read, False, Nothing)
      Catch ex As Exception
        MessageBox.Show(ex.Message)
      End Try

      Dim objId As ObjectId
      objId = database.Insert(New String("TestInsertBlock"), blockDb, True)

      Dim btr As BlockTableRecord = database.CurrentSpaceId.GetObject(DatabaseServices.OpenMode.ForWrite)
      Dim bref_ins As BlockReference = New BlockReference(New Point3d(0, 0, 0), objId)
      btr.AppendEntity(bref_ins)

      btr.Dispose()
      blockDb.Dispose()
      bref_ins.Dispose()
      Invalidate()
    End If
  End Sub

  Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
    If (Not (database Is Nothing)) Then
      If (DialogResult.OK = saveAsFileDialog.ShowDialog()) Then
        database.SaveAs(saveAsFileDialog.FileName, DwgVersion.Current)
      End If
    End If
  End Sub
End Class

