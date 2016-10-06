# TobyVision
Machine Vision using 3D color distance for edge detection

This is a very rudimentary, thrown together, project to demonstrate the effectiveness of using Color Distance for edge detection. Color Distance, at least in this implementation, is defined as the 3D Distance two colors are from each other in the RGB Color Space. Using the Get-a-pixel-put-a-pixel method and color distance methods, nd edge point can be inferred in less than 10 lines of code.
The color distance formula is as you expected:

d=√(〖(R_1  - R_2)〗^2+〖(G_1  - G_2)〗^2+〖B_1  - B_2)〗^2 )

For more detail, refer to the included research paper on the topic.

