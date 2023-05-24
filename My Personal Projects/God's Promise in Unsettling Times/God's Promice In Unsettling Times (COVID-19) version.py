#God's Promice In Unsettling Times COVID-19 Version was Developed by James Schwants
#For CUW Students that are not CS Majors, scroll down to the comment that says 'Line 162'
#Also, when you are navigating through the program makes sure to look for the # and """.
#Both of these symbols represent comments which tell the programer/user which code does what.

"""This function goes through each of the topics and calls the functions 
assoicated with that topic."""
def TopicCommands(Commands):
    if Commands == Sickness:
        print('')
        print('Here are some passage about sickness')
        SicknessPassages()
        print('')
        ContinueProgram()
    
    elif Commands == sickness:
        print('')
        print('Here are some passage about sickness')
        SicknessPassages()
        print('')
        ContinueProgram()
    
    elif Commands == Stress:
        print('')
        print('Here are some passages about Anxiety and Stress.')
        AnxietyAStressPassages()
        print('')
        ContinueProgram()
    
    elif Commands == stress:
        print('')
        print('Here are some passages about Anxiety and Stress.')
        AnxietyAStressPassages()
        print('')
        ContinueProgram()
    
    elif Commands == Hope:
        print('')
        print('Here are some passages about Hope and the Unltimate Promise.')
        HopeAPromicePassages()
        print('')
        ContinueProgram()
    
    elif Commands == hope:
        print('')
        print('Here are some passages about Hope and the Unltimate Promise.')
        HopeAPromicePassages()
        print('')
        ContinueProgram()
        
    elif Commands == Anger:
        print('')
        print('Here are some passages about Anger.')
        AngerPassages()
        print('')
        ContinueProgram()
    
    elif Commands == anger:
        print('')
        print('Here are some passages about Anger.')
        AngerPassages()
        print('')
        ContinueProgram()
    
    elif Commands == Love:
        print('')
        print('Here are some passages about Love.')
        LovePassages()
        print('')
        ContinueProgram()
    
    elif Commands == love:
        print('')
        print('Here are some passages about Love.')
        LovePassages()
        print('')
        ContinueProgram()
    
    elif Commands == Thanksgiving:
        print('')
        print('Here are some passages about Greatfulness and Thanksgiving')
        ThanksgivingPassages()
        print('')
        ContinueProgram()
    
    elif Commands == thanksgiving:
        print('')
        print('Here are some passages about Greatfulness and Thanksgiving')
        ThanksgivingPassages()
        print('')
        ContinueProgram()
    
    elif Commands == Doubt:
        print('')
        print('Here are some passages about Doubt')
        DoubtPassages()
        print('')
        ContinueProgram()
    
    elif Commands == doubt:
        print('')
        print('Here are some passages about Doubt')
        DoubtPassages()
        print('')
        ContinueProgram()
    
    elif Commands == Worry:
        print('')
        print('Here are some passages about Worry and Fear')
        WorryAFearPassages()
        print('')
        ContinueProgram()
    
    elif Commands == worry:
        print('')
        print('Here are some passages about Worry and Fear')
        WorryAFearPassages()
        print('')
        ContinueProgram()
        
"""This function asks the user if that want to continue the program. 
If yes than the program will call the TopicsACommands function. Otherwise
the program will end."""
def ContinueProgram():
    print('Would you like to explore more topics? (y/n)')
    c = input() 
    Y = 'Y'
    N = 'N'
    y = 'y'
    n = 'n' 
    if c == Y:
        TopicsACommands()
    elif c == y:
        TopicsACommands()
    else:
        print('God bless your day.')

"""This Function brings up the topic list if the user types in Topics, otherwise 
The program calls the TopicCommands and starts all over again. This function also 
prints a statement to let the user know what to do next."""
def TopicsACommands():
    print("Enter your next topic, if you don't remember the topics, type 'topics'")
    topics = 'topics'
    CT = input()
    if CT == topics:
        TopicList()
    else:
        Command = CT
        TopicCommands(Command)


def TopicList():
    print('The topics for this program are the following:')
    ListA = ['Sickness','Anxiety/Stress','Hope/Promice','Anger','Love','Thanksgiving','Doubt','Worry/Fear']
    print(ListA)

    print('Type in your next topic.')
    Commands = input()
    TopicCommands(Commands)


#CUW Students, Line 162.
#The portions of code that I desginate will be the main content of the program.
#Each function is listed with comment above it to define what it does. 
#This marks the beginning of the main content.

#This function stores the content for the introductory statement.
def IntroductionParagraph():
    Introduction = """
    Dear User

    There are many reasons as to why you might have chosen to download this program. Some of 
    them may include fear, anxiety and doubt as to what the future may hold. I have had many of 
    these same emotions that have led back to COVID-19. When I originally thought of the idea for 
    this program, I thought of my girlfriend who needed reassurance in this growing time of trails 
    and tribulations. 
    
    That is why I have created this program for you; so that you as the user can be assured that God 
    and our Lord and Savior Jesus Christ is there for you every step of the way. While it may not 
    seem obvious at first, in time, his plan is revealed to each one of us as Christians. As I am not an 
    ordained pastor, I would encourage anyone using this program, that if you have any questions 
    concerning your faith, you reach out to local pastor. I can assure that as the developer of this 
    program, it will hopefully reassure you that God is with you and he will always be with you to 
    the very end of the age.  
    
    Author and Developer

    James Schwantes"""
    print(Introduction)

#This function stores the cotent for the Sickness Passages
def SicknessPassages():
    SP = """
    
    Exodus 23:25
    You shall serve the Lord your God, and he will bless your bread and your water, and I will 
    take sickness away from among you.
    
    
    Isaiah 38:1-8
    In those days Hezekiah became sick and was at the point of death. And Isaiah the prophet the 
    son of Amoz came to him, and said to him, “Thus says the Lord: Set your house in order, for you 
    shall die, you shall not recover." Then Hezekiah turned his face to the wall and prayed to the 
    Lord, and said, “Please, O Lord, remember how I have walked before you in faithfulness and 
    with a whole heart, and have done what is good in your sight.” And Hezekiah wept bitterly.
    
    Then the word of the Lord came to Isaiah: “Go and say to Hezekiah, thus says the Lord, the God 
    of David your father: I have heard your prayer; I have seen your tears. Behold, I will add fifteen 
    years to your life. I will deliver you and this city out of the hand of the king of Assyria and will 
    defend this city. 
    
    This shall be the sign to you from the Lord, that the Lord will do this thing that he has promised: 
    Behold, I will make the shadow cast by the declining sun on the dial of Ahaz turn back ten 
    steps.” So, the sun turned back on the dial the ten steps by which it had declined.
    
    
    Isaiah 33:24
    And no inhabitant will say, “I am sick”;  the people who dwell there will be forgiven their iniquity.
    
    
    Mathew 9:12
    But when he heard it, he said, “Those who are well have no need of a physician, but those who are sick.
    
    
    James 5:14-15
    Is anyone among you sick? Let him call for the elders of the church, and let them pray over 
    him, anointing him with oil in the name of the Lord. And the prayer of faith will save the one 
    who is sick, and the Lord will raise him up. And if he has committed sins, he will be forgiven. """
    
    print(SP)
 
#This function stores the content for the Anxiety and Stress passages.   
def AnxietyAStressPassages():
    AASP = """
    
    Proverbs 12:25
    Anxiety in a man's heart weighs him down, but a good word makes him glad.
    
    
    2 Corinthians 11:27-33
    In toil and hardship, through many a sleepless night, in hunger and thirst, often without food, 
    in cold and exposure. And, apart from other things, there is the daily pressure on me of my 
    anxiety for all the churches. Who is weak, and I am not weak? Who is made to fall, and I am not indignant?
    
    If I must boast, I will boast of the things that show my weakness. The God and Father of the 
    Lord Jesus, he who is blessed forever, knows that I am not lying. At Damascus, the governor 
    under King Aretas was guarding the city of Damascus in order to seize me, but I was let down in 
    a basket through a window in the wall and escaped his hands.
    
    
    1 Peter 5:7
    Casting all your anxieties on him, because he cares for you."""
    
    print(AASP)
 
#This function stores the content for the Hope and The Unltimate Promice passages.
def HopeAPromicePassages():
    HAPP = """
    
    Psalm 65:5
    By awesome deeds you answer us with righteousness, O God of our salvation, the hope of all 
    the ends of the earth and of the farthest seas; 
    
    
    Psalm 71:14
    But I will hope continually and will praise you yet more and more.
    
    
    Jerimiah 14:22
    Are there any among the false gods of the nations that can bring rain? Or can the heavens 
    give showers? Are you not he, O Lord our God? We set our hope on you, for you do all these things.
    
    
    Romans 15:13
    May the God of hope fill you with all joy and peace in believing, so that by the power of the 
    Holy Spirit you may abound in hope.
    
    
    2 Thessalonians 2:16
    Now may our Lord Jesus Christ himself, and God our Father, who loved us and gave us 
    eternal comfort and good hope through grace,"""
    
    print(HAPP)

#This function stores the content for the Anger passages.   
def AngerPassages():
    AP = """
    
    Numbers 14:18
    ‘The Lord is slow to anger and abounding in steadfast love, forgiving iniquity and 
    transgression, but he will by no means clear the guilty, visiting the iniquity of the fathers on the 
    children, to the third and the fourth generation.’
    
    
    Proverbs 14:29
    Whoever is slow to anger has great understanding, but he who has a hasty temper exalts folly.
    
    
    Proverbs 16:32
    Whoever is slow to anger is better than the mighty, and he who rules his spirit than he who takes a city. 
    
    
    Joel 2:13
    And rend your hearts and not your garments.” Return to the Lord your God, for he is gracious 
    and merciful, slow to anger, and abounding in steadfast love; and he relents over disaster. 
    
    
    Ephesians 4:26
    Be angry and do not sin; do not let the sun go down on your anger."""
    
    print(AP)
 
#This function stores the content for the Love passages.  
def LovePassages():
    LP = """
    
    Psalm 36:5
    Your steadfast love, O Lord, extends to the heavens, your faithfulness to the clouds.
    
    
    Job 10:12
    You have granted me life and steadfast love, and your care has preserved my spirit.
    
    
    Psalm 107:1
    Oh give thanks to the Lord, for he is good, for his steadfast love endures forever!
    
    
    John 21:15-19
    When they had finished breakfast, Jesus said to Simon Peter, “Simon, son of John, 
    do you love me more than these?” He said to him, “Yes, Lord; you know that I love you.” He said to 
    him, “Feed my lambs.” He said to him a second time, “Simon, son of John, do you love me?” He 
    said to him, “Yes, Lord; you know that I love you.” He said to him, “Tend my sheep.” He said to 
    him the third time, “Simon, son of John, do you love me?” Peter was grieved because he said to 
    him the third time, “Do you love me?” and he said to him, “Lord, you know everything; you 
    know that I love you.” Jesus said to him, “Feed my sheep. Truly, truly, I say to you, when you 
    were young, you used to dress yourself and walk wherever you wanted, but when you are old, 
    you will stretch out your hands, and another will dress you and carry you where you do not want 
    to go.” (This he said to show by what kind of death he was to glorify God.) And after saying this 
    he said to him, “Follow me.”
    
    
    John 3:16
    “For God so loved the world, that he gave his only Son, that whoever believes in him should 
    not perish but have eternal life."""
    
    print(LP)

#This function stores the content for the Greatfullness and Thanksgiving Passages.   
def ThanksgivingPassages():
    TP = """
    
    Psalm 50:12-15
    If I were hungry, I would not tell you, for the world and its fullness are mine. Do I eat the 
    flesh of bulls or drink the blood of goats? Offer to God a sacrifice of thanksgiving, and perform 
    your vows to the Most High, and call upon me in the day of trouble; I will deliver you, and you 
    shall glorify me.”
    
    
    Psalm 100:4 
    Enter his gates with thanksgiving, and his courts with praise! Give thanks to him; bless his name! 
    
    
    Jonah 2:9
    But I with the voice of thanksgiving will sacrifice to you; what I have vowed I will pay. 
    Salvation belongs to the Lord!” 
    
    
    2 Corinthians 9:11
    You will be enriched in every way to be generous in every way, which through us will 
    produce thanksgiving to God. 
    
    
    Revelation 7:12
    And all the angels were standing around the throne and around the elders and the four living 
    creatures, and they fell on their faces before the throne and worshiped God, saying, “Amen! 
    Blessing and glory and wisdom and thanksgiving and honor and power and might be to our God 
    forever and ever! Amen.”"""
    
    print(TP)

#This function stores the content for the Doubt passages.  
def DoubtPassages():
    DP = """
    
    Jude 1:22
    And have mercy on those who doubt;
    
    
    Mathew 14:26-32
    But when the disciples saw him walking on the sea, they were terrified, and said, “It is a 
    ghost!” and they cried out in fear. But immediately Jesus spoke to them, saying, “Take heart; it is 
    I. Do not be afraid.” 
    
    And Peter answered him, “Lord, if it is you, command me to come to you on the water.” He said, 
    “Come.” So Peter got out of the boat and walked on the water and came to Jesus. But when he 
    saw the wind, he was afraid, and beginning to sink he cried out, “Lord, save me.” Jesus 
    immediately reached out his hand and took hold of him, saying to him, “O you of little faith, why 
    did you doubt?” And when they got into the boat, the wind ceased. And those in the boat 
    worshiped him, saying, “Truly you are the Son of God.”"""
    
    print(DP)

#This function stores the content for the Worry and Fear passages.    
def WorryAFearPassages():
    WAFP = """
    
    Genesis 15:1
    After these things the word of the Lord came to Abram in a vision: “Fear not, Abram, I am 
    your shield; your reward shall be very great.” 
    
    
    Genesis 26:24
    And the Lord appeared to him the same night and said, “I am the God of Abraham your 
    father. Fear not, for I am with you and will bless you and multiply your offspring for my servant 
    Abraham's sake.”
    
    
    Psalm 27:1
    The Lord is my light and my salvation; whom shall I fear? The Lord is the stronghold of my 
    life; of whom shall I be afraid? 
    
    
    Isaiah 41:10
    Fear not, for I am with you; be not dismayed, for I am your God; I will strengthen you, I will 
    help you, I will uphold you with my righteous right hand. 
    
    
    Psalm 112:1
    Praise the Lord! Blessed is the man who fears the Lord, who greatly delights in his commandments!"""
    
    print(WAFP)

#This marks the end of the main content.
    
"""These print statements are the beginning statements to the program
and the secound print statement will ask the user to put in a blank input
in order to move on to the IntroductionParagraph. This is implemented to make sure
that the user is not overwelmed"""           
print('Gods Promise In Unsettling Times. COVID-19 Version')
print('Hello New User, press any key to continue')
a = input()

"""Calls the IntroducionParagraph function and puts a space between the Introduction
and the next statement"""
IntroductionParagraph()
print('')
print('Press any key to continue.')

"""Another blank input is called and a space is put in between the introduction
and the next statment."""
b = input()
print('')

"""The topics are listed along with an initial list, information is given to the user
and instructions the user what to do next."""
print('The topics for this program are the following:')
ListA = ['Sickness','Stress','Hope','Anger','Love','Thanksgiving','Doubt','Worry']
print(ListA)
print('')
print('All of the Bible passages in this program use the ESV translation.')
print('Type in the topic that your are struggling in and see the bible passages associated with it.')

#Inital variables are set up for the commands. 
Sickness = 'Sickness'
sickness = 'sickness' 
Stress = 'Stress'
stress = 'stress'
Hope = 'Hope'
hope = 'hope'
Anger = 'Anger'
anger = 'anger'
Love = 'Love'
love = 'love'
Thanksgiving = 'Thanksgiving'
thanksgiving = 'thanksgiving'
Doubt = 'Doubt'
doubt = 'doubt'
Worry = 'Worry'
worry = 'worry'

#When the user puts in a command the TopicCommands function is called.
Commands = input()
TopicCommands(Commands)
input()
