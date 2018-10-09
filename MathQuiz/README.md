# Tutorial 1: Create a picture viewer in Visual Basic
(Please refer to the Microsoft Docs website: https://code.msdn.microsoft.com/Complete-Picture-Viewer-7d91d3a8)

This is a step by step tutorial.

- Step 1: Create a Windows Forms Application Project

If any of these windows are missing, restore the default window layout by, on the menu bar, choosing Window > Reset Window Layout.
- Step 2: Run Your Program

Be sure you're looking at Windows Forms Designer.
- Step 3: Set Your Form Properties

Properties can be ordered by a Categorized or Alphabetical view. You can switch between these two views by using the buttons on the Properties window.
- Step 4: Lay Out Your Form with a TableLayoutPanel Control

You can add controls like buttons, check boxes, and labels to your form. Double-click the TableLayoutPanel control in the Toolbox.
That's the IDE auto-hide feature. You can turn it on or off for any of the windows by choosing the **pushpin icon**.

After you set the TableLayoutPanel Dock property to Fill, the panel fills the entire form. If you resize the form again, the TableLayoutPanel stays docked, and resizes itself to fit.

Choose the **triangle button** to display the control's task list, as shown in the following picture.
- Step 5: Add Controls to Your Form

Choose the Dock in parent container link. This automatically sets the PictureBox Dock property to Fill.(Understand the meaning of Dock here.)

Then dock the FlowLayoutPanel in the TableLayoutPanel (either by choosing Dock in parent container on the FlowLayoutPanel's black triangle task list, or by setting the FlowLayoutPanel's Dock property to Fill).

A FlowLayoutPanel is a container that arranges other controls in neat rows in order. When you resize a FlowLayoutPanel, if it has room to lay out all of its controls in a single row, it does that. Otherwise, it arranges them in lines, one on top of the other. 
- Step 6: Name Your Button Controls

Double-click the Show a picture button on the form. As an alternative, choose the Show a picture button on the form, and then choose the Enter key. When you do, the IDE opens an additional tab in the main window called Form1.cs. This tab shows the code file behind the form.

At design-time, when you open the code file for a control in a form, code is generated for the control if it doesn't already exist. (It is when you open code file, code will be generated.)

The five methods that you added are called event handlers, because your program calls them whenever an event (like a user choosing a button or selecting a box) happens.
- Step 7: Add Dialog Components to Your Form

But unlike a **control**, adding a **component** to your form doesn't add a visible item that the user can see on the form. Instead, it provides certain behaviors that you can trigger with code.

Also, notice how the Title and Filter properties are bold in the Properties window. The IDE does that to show you any properties that have been changed from their default values.
- Step 8: Write Code for the Show a Picture Button Event Handler
- Step 9: Review, Comment, and Test Your Code
- Step 10: Write Code for Additional Buttons and a Check Box
- Step 11: Run Your Program and Try Other Features





