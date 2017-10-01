# A Persona-based Modelling for Contextual Requirements

## Contexts

### Pacient Context

Ch: Health Risk:  
F1 - Has Diabetes  
F2 - Has HBP  
F3 - Cardiac  
F4 - Has rheumatiod  
F5 - Prone to falling  
F6 - Has osteoporosis  
Ch:(F1 || F2 || F3 || F4 || F5 || F6)

Cm: Mobility issue:  
F7 - Difficulty in walking  
F8 - Has a wheel chair  
Cm:(F7 || F8)

Ct: Tecnology aversion:  
F9 - Don't like tecnology  
F10 - Has bad experiences with tecnology  
F19 - Wants to avoid frustating experiences with tecnoloies  
Ct:(F9 || F10)

Cha: Home assistance:  
F11 - Lives with his/hers childrens  
F12 - Has a nurse  
F13 - Lives in an asylum  
F14 - Has an assisted living device  
Cha:(F11 || F12 || F13 || F14)

Ca: Physical activity:  
F15 - Walks/Runs as a physical activity  
Ca:(F15)

Ch:(F1 || F2 || F3 || F4 || F5 || F6)  
Cm:(F7 || F8)  
Ct:(F9 || F10)  
Cha:(F11 || F12 || F13 || F14)  
Ca:(F15)  

### Doctor Context

Cc: Means of communication: 
F16 - Cell phone  
F17 - Internet  
Cc:(F16 || F17)

Ci: Means of information:  
F17 - Internet  
Ci:(F17)

Che: Means of helping:  
F18 - Ambulance access  
Che:(F18)

Cc:(F16 || F17)  
Ci:(F17)  
Che:(F18)  

## Goals

Here are described the logical formulas of each of our goal.
In it we have an identifier that begins with the letter G,
followed by the number of the goal. Then we have its description and
finally, in parenthesis, its logical formula of prerequisites

G1: responds to emergency (G2 && G3 && G4 && G5)

G2: emergency is detected (G6 || G7)

G3: is notified about emergency (T1 || T2 || T3 || T4)

G4: central recives info (G8 && G9)

G5: medical care reaches p (G10 && (PC && Ch || DC && Che))

G6: call for help is accepted (G11 && G12)

G7: Situations are identified (T5 && (G13 && (PC && (Ch || Ca) || DC)) && (T6 && (PC && (Ch || Ca) || DC)))

G8: info is sent to emergency (T7 && (PC && !Ct || DC && Cc) && T8 && (PC && !Ct || DC && Cc))

G9: info is prepared (G14 || G15)

G10: ambulance is dispatched to location (T21)

G11: recives emergency button call (T9 && (PC && (!Ct V Cha) || DC && Ci) || T10 && (PC && (!Ct V Cha) || DC && Ci))

G12: false alarms is checked  (T11 && (PC && (Cha && !Ct) || DC && Cc) || G16 && (PC && (Cha && !Ct) || DC && Cc))

G13: vital signs are monitored (T12 && T13)

G14: setup automated info (G17 && G18)

G15: contact responsible for (T14)

G16: is contacted (T15)

G17: location is identified (T16 && (PC && !Cm || DC) || T17 && (PC && (!Cm || Cha || Ct) || DC) || T18 && (PC && (!Cm || !Ct) || DC) || T19 && (PC && (!Cm || !Ct) || DC))

G18: situation data is recovered (T20)

G1:(G2 && G3 && G4 && G5)  
G2:(G6 || G7)  
G3:(T1 || T2 || T3 || T4)  
G4:(G8 && G9)  
G5:(G10 && (PC && Ch || DC && Che))  
G6:(G11 && G12)  
G7:(T5 && (G13 && (PC && (Ch || Ca) || DC)) && (T6 && (PC && (Ch || Ca) || DC)))  
G8:(T7 && (PC && !Ct || DC && Cc) && T8 && (PC && !Ct || DC && Cc))  
G9:(G14 || G15)  
G10:(T21)  
G11:(T9 && (PC && (!Ct V Cha) || DC && Ci) || T10 && (PC && (!Ct V Cha) || DC && Ci))  
G12:(T11 && (PC && (Cha && !Ct) || DC && Cc) || G16 && (PC && (Cha && !Ct) || DC && Cc))  
G13:(T12 && T13)  
G14:(G17 && G18)  
G15:(T14)  
G16:(T15)  
G17:(T16 && (PC && !Cm || DC) || T17 && (PC && (!Cm || Cha || Ct) || DC) || T18 && (PC && (!Cm || !Ct) || DC) || T19 && (PC && (!Cm || !Ct) || DC))  
G18:(T20)  

## Personas
Mary's Context:  
![Mary's Context](/mary.png?raw=true "Mary's Context")    
Ch:(F1 && F5 && F6)  
Cm:()  
Ct:(F19)  
Cha:(F14)  
Ca:()	  
Mary(1):(F1,F5,F6,F14,F19)  
Mary ContextSet:{Ch, Cha, Ct}  

Jennifer's Context:  
![Jennifer's Context](/jennifer.PNG?raw=true "Jennifer's Context")    
Ch:(F1)  
Cm:()  
Ct:()  
Cha:(F11, F14)  
Ca:(F15)  
Jennifer(2):(F1,F11,F14,F15)  
Jennifer ContextSet: {Ch, Cha, Ca}  

Dorothy's Context:  
![Dorothy's Context](/dorothy.PNG?raw=true "Dorothy's Context")    
Ch:(F1 && F2 && F3 && F5)  
Cm:(F7)  
Ct:()  
Cha:(F11, F14)  
Ca:(F15)	  
Dorothy(3):(F1,F2,F3,F5,F7,F11,F14,F15)  
Dorothy ContextSet:{Ch, Cm, Cha, Ca}

Paul's Context:  
![Paul's Context](/paul.PNG?raw=true "Paul's Context")   
Cc:(F16 && F17)  
Ci:(F17)  
Che:(F18)  
Paul(4):(F16,F17,F18)  
Paul ContextSet:{Cc, Ci, Che}

## Metrics And examples:

Q1: Is the algorithm efficient to come up
with an execution plan (Execution time.  )
	Mary 00:00:00.0000406  
	Jennifer 00:00:00.0000240  
	Dorothy 00:00:00.0000165  
	Paul 00:00:00.0000223  
  
Q2: Is the root goal achieved for each
modelled persona? (Yes/No)
	Mary No    
	Jennifer Yes  
	Dorothy Yes  
	Paul Yes  
  
Q3: Are the plans provided by the
algorithm correct? (% of correct
plans)
	Mary 100%  
	Jennifer 100%  
	Dorothy 100%  
	Paul 100%  

OUTPUT Example:  
Start. MARY  
The main goal is NOT achievable.  
Failed Goal: G4  
Execution Time: 00:00:00.0000406.  
End.  
Start. JENNIFER  
The main goal is achievable.  
The plan is:  
T21  
T20  
T17  
T7  
T1  
T11  
T9  
Execution Time: 00:00:00.0000240.  
End.  
Start DOROTHY.  
The main goal is achievable.  
The plan is:  
T21  
T20  
T16  
T7  
T1  
T11  
T9  
Execution Time: 00:00:00.0000165.  
End.  
Start PAUL.  
The main goal is achievable.  
The plan is:  
T21  
T20  
T16  
T7  
T1  
T11  
T9  
Execution Time: 00:00:00.0000223.  
End.  
Press any key to quit.  
