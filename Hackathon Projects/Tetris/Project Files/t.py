from  tkinter import*
from PIL import Image, ImageTk
import pygame
import threading
import random

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
            [2,2],
            [2,2]
        ]
    ]
    tShape = [
        [
            [3,0],
            [3,3],
            [3,0]
        ],
        [
            [0,3,0],
            [3,3,3]
        ],
        [
            [0,3],
            [3,3],
            [0,3]
        ],
        [
            [3,3,3],
            [0,3,0]
        ]
    ]
    zShape = [
        [
            [4,0],
            [4,4],
            [0,4]
        ],
        [
            [4,4,0],
            [0,4,4]
        ]
    ]
    zShape2 = [
        [
            [0,5],
            [5,5],
            [5,0]
        ],
        [
            [0,5,5],
            [5,5,0]
        ]
    ]
    lShape = [
        [
            [6,0],
            [6,0],
            [6,6]
        ],
        [
            [6,0,0],
            [6,6,6]
        ],
        [
            [6,6],
            [6,0],
            [6,0]
        ],
        [
            [6,6,6],
            [0,0,6]
        ]
    ]
    block = []
    ShapeType = [line, square, tShape, zShape, zShape2, lShape]
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
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0],
            [0,0,0,0,0,0,0,0,0,0]
        ]

    def CollisionCheckDown(self, mt, xpos, ypos):
        #check if the thing touches the bottom
        if ypos + len(mt) >= 18:
            return True       
        for y in range(len(mt)-1,0, -1):
            if y == len(mt)-1:
                for x in range(0,len(mt[y])):
                    if mt[y][x] != 0 and self.grid[ypos + y + 1][xpos + x] != 0:
                        return True
            else:
                for x in range(0,len(mt[y])):
                    if mt[y][x] != 0 and mt[y + 1][x] == 0 and self.grid[ypos + y + 1][xpos + x] != 0:
                        return True
        return False

    #def CollisionCheckRight(self, mt, xpos, ypos): 
    #    if xpos + len(mt[0]) > 10:
    #        return True

    #    for x in range(len(mt[0])-1,0, -1):
    #        if x == len(mt[0])-1:
    #            for y in range(0,len(mt)):
    #                if xpos + len(mt[0]) != 10 and mt[y][x] != 0 and self.grid[ypos + y][xpos + x + 1] != 0:
    #                    return True
    #        else:
    #            for y in range(0,len(mt)):
    #                if mt[y][x] != 0 and mt[y][x + 1] == 0 and self.grid[ypos + y][xpos + x + 1] != 0:
    #                    return True
    #    return False

    def isFull(self):
        for y in range (0, 18):
            for x in range (0, 10):
                if self.grid[y][x] == 0:
                    break
                if x == 9:
                    self.deleteRow(y)
                    return y
        return -1

    def deleteRow(self, row):
        self.grid[row] = [0,0,0,0,0,0,0,0,0,0]
        self.moveRow(row)

    def moveRow (self, row):
        if(row == 0):
            self.grid[row] = [0,0,0,0,0,0,0,0,0,0]
        else:
            #self.grid[row] = self.grid[row - 1]
            for i in range(0, 10):
                self.grid[row][i] = self.grid[row - 1][i]

            self.moveRow(row - 1)

class MainWindow(Canvas):

    g = Grid()
    b = Shape(random.randrange (0,5))
    pos = 0
    gamerunning = True
    timeRate = 150

    def loadsounds(self):
        self.rs = pygame.mixer.Sound("RotationEffect16.wav")
        self.Goe = pygame.mixer.Sound("GameOverEffect16.wav")
        self.hs = pygame.mixer.Sound("HitblockandbottomEffect16.wav")
        self.cler = pygame.mixer.Sound("ClearLineEffect16.wav")
    def loadImages(self):
        try:
            self.orange = Image.open("orangeBlock.png")
            self.oi = ImageTk.PhotoImage(self.orange)
            self.grey = Image.open("greyBlock.png")
            self.gi = ImageTk.PhotoImage(self.grey)
            self.blue = Image.open("blueBlock.png")
            self.bi = ImageTk.PhotoImage(self.blue)
            self.pink = Image.open("pinkBlock.png")
            self.pi = ImageTk.PhotoImage(self.pink)
            self.purple = Image.open("purpleBlock.png")
            self.pui = ImageTk.PhotoImage(self.purple)
            self.red = Image.open("redBlock.png")
            self.ri = ImageTk.PhotoImage(self.red)
            self.yellow = Image.open("yellowBlock.png")
            self.yi = ImageTk.PhotoImage(self.yellow)
            self.bgimg = Image.open("bg.jpeg")
            self.bg = ImageTk.PhotoImage(self.bgimg)
            self.goimg = Image.open("GameOverMenu.jpeg")
            self.go = ImageTk.PhotoImage(self.goimg)
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


    # def playtheme(self):
    #     pygame.mixer.music.load("Tetris.mp3") #Loading File Into Mixer
    #     pygame.mixer.music.play() #Playing It In The Whole Device

    # def playtheme(self):
    #     pygame.mixer.music.load("Tetris.mp3") #Loading File Into Mixer
    #     pygame.mixer.music.play() #Playing It In The Whole Device
    
    def speedDown(self):
        self.timeRate= 50
    def slowDown (self):
        self.timeRate=150

    def handle_events (self, event):
        if event.keysym == "Left": self.moveLeft()
        if event.keysym == "Right": self.moveRight()
        if event.keysym == "Up": 
            self.b.rotate()
            self.rs.play()
        if event.keysym == "Down": self.speedDown()

    def release(self, event):
        if event.keysym == "Down": self.slowDown()
     
    #change position of the block
    def moveLeft (self):
        if self.b.xpos > 0 and not self.g.CollisionCheckDown(self.b.getBlock(), self.b.xpos - 1, self.b.ypos):
            self.b.xpos -= 1
    def moveRight(self):
        if self.b.xpos < 10 - len(self.b.getBlock()[0]) and not self.g.CollisionCheckDown(self.b.getBlock(), self.b.xpos + 1, self.b.ypos):
            self.b.xpos += 1
        

    def drawBlock(self, block):
        b = block.getBlock()
        for y in range (0, len(b)):
            for x in range (0, len(b[0])):
                if b[y][x] != 0:
                    xpos = (x + block.xpos)*25
                    ypos = (y + block.ypos)*25
                    if b[y][x] == 1:
                        self.create_image(xpos, ypos, image=self.oi, anchor=NW,  tag="head")
                    if b[y][x] == 2:
                        self.create_image(xpos, ypos, image=self.yi, anchor=NW,  tag="head")
                    if b[y][x] == 3:
                        self.create_image(xpos, ypos, image=self.bi, anchor=NW,  tag="head")
                    if b[y][x] == 4:
                        self.create_image(xpos, ypos, image=self.pi, anchor=NW,  tag="head")
                    if b[y][x] == 5:
                        self.create_image(xpos, ypos, image=self.pui, anchor=NW,  tag="head")
                    if b[y][x] == 6:
                        self.create_image(xpos, ypos, image=self.ri, anchor=NW,  tag="head")

    def drawGrid(self):
        for i in range (0, 18):
            for j in range (0, 10):
                if self.g.grid[i][j] != 0:
                    xpos = j*25
                    ypos = i*25
                    #self.create_image(xpos, ypos, image=self.bi, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 1:
                        self.create_image(xpos, ypos, image=self.oi, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 2:
                        self.create_image(xpos, ypos, image=self.yi, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 3:
                        self.create_image(xpos, ypos, image=self.bi, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 4:
                        self.create_image(xpos, ypos, image=self.pi, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 5:
                        self.create_image(xpos, ypos, image=self.pui, anchor=NW,  tag="head")
                    if self.g.grid[i][j] == 6:
                        self.create_image(xpos, ypos, image=self.ri, anchor=NW,  tag="head")
    
    def gameover(self):
        self.gamerunning = False
        self.Goe.play()
        pygame.mixer.music.stop()

    def Collider(self):
        if self.b.ypos == 0:
            self.gameover()

        cb = self.b.getBlock()
        for y in range (0,len(cb)):
            for x in range (0,len(cb[0])):
                if self.g.grid[self.b.ypos + y][self.b.xpos + x] == 0:
                    self.g.grid[self.b.ypos + y][self.b.xpos + x] = cb[y][x]
        self.b = Shape(random.randrange (0,6))
        self.hs.play()

    def time(self):
        self.delete("all")
        if self.gamerunning:
            self.create_image(0, 0, image=self.bg, anchor=NW,  tag="head")
            self.drawGrid()    
            self.drawBlock(self.b)
            if(self.g.CollisionCheckDown(self.b.getBlock(),self.b.xpos,self.b.ypos)):
                self.Collider()
            else:
                self.b.ypos += 1
            if self.g.isFull() > 0:
                self.cler.play()
            self.after(self.timeRate, self.onTimer)
        else:
            self.create_image(0, 0, image=self.go, anchor=NW,  tag="head")
            #self.drawBlock(self.b)
        
    def onTimer(self):
        self.time()
        
    def initGame(self):
        pygame.init()
            
        self.loadImages()
        self.loadsounds()
        self.playtheme()
        
        self.after(self.timeRate, self.onTimer)
        self.bind_all("<Key>", self.handle_events)
        self.bind_all('<KeyRelease>',self.release)
        self.pack()        
        root.mainloop()
    
root = Tk()    
root.geometry("250x450")
mw = MainWindow()
root.add