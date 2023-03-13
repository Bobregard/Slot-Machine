# Slot-Machine

● At the start of the game the player should enter the deposit amount (e.g. the initial money
balance).

● After that, for each spin, the player is asked how much money he wants to stake.

● A table with the results of each spin is displayed to the player.

● The win amount should be displayed together with the total balance at the current stage.
After the first spin the total balance will be equal to:
({deposit amount} - {stake amount}) + {win amount}.

● Game ends when the player balance hits 0.

The game:

● A slot game with dimensions 4 rows of 3 symbols each.

● Supports following symbols:

Symbol &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Coefficient &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Probability to appear on a cell

Apple (A) &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  0.4  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;  45%
<br /> Banana (B) &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  0.6  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;  35%
<br />Pineapple (P) &nbsp;&nbsp;&nbsp;&nbsp;  0.8  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;  15%
<br />Wildcard (*) &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  0  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  5%
