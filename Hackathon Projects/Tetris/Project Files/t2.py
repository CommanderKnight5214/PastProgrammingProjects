from  tkinter import*
from PIL import Image, ImageTk
import pygame
import threading

class Shape:
    line = [
        [
            [1],
            [1],
            [1],
            [1]
        ],
        [
            [1,1,1,1]
        ]
    ]
    square = [
        [
            [1,1],
            [1,1]
        ]
    ]
    tShape = [
        [
            [1,0],
            [1,1],
            [1,0]
        ],
        [
            [0,1,0],
            [1,1,1]
        ]
    ]
    zShape = [
        [
            [1,0],
            [1,1],
            [0,1]
        ],
        [
            [1,1,0],
            [0,1,1]
        ]
    ]
    lShape = [
        [
            [1,0],
            [1,0],
            [1,1]
        ],
        [
            [1,0,0],
            [1,1,1]
        ]
    ]

    block = []
    ShapeType = [line, square, tShape, zShape, lShape]
    rotateIndex = 0
    xpos = 0
    ypos = 0

    def __init__(self, shape):
        self.block = self.ShapeType[shape]
    
    def rotate(self):
        if (self.rotateIndex + 1 < len(self.block)):
            self.rotateIndex +=1
        else:
            self.rotateIndex = 0
            
    def getBlock(self):
        return self.block[self.rotateIndex]

class Grid():
    grid = [
            [1,0,0,0,0,0,0,0,0,1],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,1,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [1,1,1,1,1,1,1,1,1,1]
        ]
    #Collision detection
    def CollusionCheck(matrix, xpos, ypos):
        for y in range(len(matrix)-1,0):
            if y == len(matrix)-1:
                for x in range(0,len(matrix[y])):
                    if matrix[y][x] != 0 and grid[ypos + y + 1][xpos + x] != 0:
                        return True
            else:
                for x in range(0,len(matrix[y])):
                    if matrix[y][x] != 0 and matrix[ y + 1][x] == 0 and grid[ypos + y + 1][xpos + x] != 0:
                        return True
        return False
        
    #def __init__(self):
    #    self.grid = grid
    def isFull(self):
        for y in range (0, 18):
            for x in range (0, 10):
                if self.grid[y][x] == 0:
                    break
                if x == 9:
                    deleteRow(y)
                    return y
        return -1
    def deleteRow(self, row):
        self.grid[row] = [0,0,0,0,0,0,0,0,0,0]

class MainWindow(Canvas):
    g = Grid()
    b = Shape(2)

	#pos = 0
#	orange = Image.open("orangeBlock.png")
#	blue = Image.open("blueBlock.png")
#	yellow = Image.open("yellowBlock.png")
#	purple = Image.open("purpleBlock.png")
#	brown = Image.open("brownBlock.png")
#	pink = Image.open("pinkBlock.png")
#	grey = Image.open("greyBlock.png")
#	red = Image.open("redBlock.png")
	
    def loadImages(self):
        try:
            self.orange = Image.open("orangeBlock.png")
            self.oi = ImageTk.PhotoImage(self.idot)
            self.grey = Image.open("greyBlock.png")
            self.gi = ImageTk.PhotoImage(self.ihead)
            self.blue = Image.open("blueBlock.png")
            self.bi = ImageTk.PhotoImage(self.iapple)
    	except IOError as e:
            print(e)
            sys.exit(1)
            
	def __init__(self):
		super().__init__(width=250, height=450, background="black", highlightthickness=0)
		self.initGame()
		self.pack()
	
	def playtheme(self):
	    pygame.mixer.music.load("Tetris.mp3") #Loading File Into Mixer
	    pygame.mixer.music.play() #Playing It In The Whole Device
	    
	def handle_events (self, event):
		if event.keysym == "Left": print("Left")
		if event.keysym == "Right": print("Right")
		if event.keysym == "Up": print("Up")
		if event.keysym == "Down": print("Down")
			
	def drawBlock(self, block):
		b = block.getBlock()
		for y in range (0, len(b)):
			for x in range (0, len(b[0])):
				if b[y][x] != 0:
#					load = self.grey
#					render = ImageTk.PhotoImage(load)
#					img = Label(image=render, borderwidth=0, padx=0, pady=0)
#					img.image = render
					xpos = (x + block.xpos)*25
					ypos = (y + block.ypos)*25
					self.create_image(xpos, ypos, image=self.oi, anchor=NW,  tag="head")
#					img.place(x=xpos, y=ypos)

	def drawGrid(self):
		for i in range (0, 18):
			for j in range (0, 10):
				if self.g.grid[i][j] != 0:
#					load = self.orange
#					render = ImageTk.PhotoImage(load)
#					img = Label(image=render, borderwidth=0, padx=0, pady=0)
#					img.image = render
					xpos = j*25
					ypos = i*25
					self.create_image(xpos, ypos, image=self.bi, anchor=NW,  tag="head")
#					img.place(x=xpos, y=ypos)

	def time(self):
		self.delete("all")
		self.drawGrid()	
		self.drawBlock(self.b)
		self.b.ypos += 1
		#print("yee")    	    
		
	def onTimer(self):
		self.time()
		self.after(100, self.onTimer)
		
	def initGame(self):
		#root = Tk()
		pygame.init()
		#c = Canvas(root, height = 250, width = 300, bg ="blue")
		#line = c.create_line(5,5,200,200, width=10)
		#oval = c.create_oval(20,20,100,100, fill ="red")
		#arc = c.create_arc(10,50,240,210, extent= 150, fill ="red")
		#rectangle = self.create_rectangle(40,50,100,100, fill ="red")

		#load = Image.open("orangeBlock.png")
		#render = ImageTk.PhotoImage(load)
		
		#img = Label(image=render, borderwidth=0)
		#img.image = render
		#img.place(x=0, y=0)
		#img.place(x=0, y=100)
		
		#load = Image.open("redBlock.png")
		#render = ImageTk.PhotoImage(load)
		
		#img = Label(image=render)
		#img.image = render
		#img.place(x=50, y=0)
		    
		self.loadImages()
		self.playtheme()
		
		self.after(100, self.onTimer)
		self.bind_all("<Key>", self.handle_events)
		self.pack()		
		root.mainloop()

#def startTimer(): 
#    threading.Timer(1, startTimer).start()
#    whatWeDoWhenTimerFires()

#startTimer()
	
root = Tk()	
root.geometry("250x450")
mw = MainWindow()
root.add