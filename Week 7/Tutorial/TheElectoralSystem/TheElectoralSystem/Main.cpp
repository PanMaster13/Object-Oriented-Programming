#include <iostream>
#include "Voter.h"
#include "Candidate.h"
#include "postType.h"
#include "Election.h"
#include "ElectionCommittee.h"

using namespace std;

int main()
{
	//The Main.cpp is used as some sort of Unit Testing for this Task (In this case, simulating an election)

	//Setting up Objects via Initialisation
	Election *electionThisYear = new Election(); //Election Object

	ElectionCommittee *committee1 = new ElectionCommittee("Eris"); //Election Committee no.1
	ElectionCommittee *committee2 = new ElectionCommittee("Aqua"); //Election Committee no.2

	Candidate *candidate1 = new Candidate(1001, "Ken", "Science", 2001, President); //President candidate 1
	Candidate *candidate2 = new Candidate(1002, "Ben", "ICT", 2002, President); //President candidate 2

	Candidate *candidate3 = new Candidate(1003, "Lisa", "Arts", 2003, VicePresident); //VicePresident candidate 1
	Candidate *candidate4 = new Candidate(1004, "Kyrie", "Business", 2004, VicePresident); //VicePresident candidate 2

	Candidate *candidate5 = new Candidate(1005, "Amy", "ICT", 2005, Secretary); //Secretary candidate 1
	Candidate *candidate6 = new Candidate(1006, "Josuke", "Business", 2006, Secretary); //Secretary candidate 2

	Candidate *candidate7 = new Candidate(1007, "Kira", "Science", 2007, Treasurer); //Treasurer candidate 1
	Candidate *candidate8 = new Candidate(1008, "Kurzawa", "Arts", 2008, Treasurer); //Treasurer candidate 2

	Voter *voter1 = new Voter(1009, "Jonathan", "Science", 2009); //Voter no.1
	Voter *voter2 = new Voter(1010, "Joseph", "Business", 2010); //Voter no.2
	Voter *voter3 = new Voter(1011, "Erina", "Arts", 2011); //Voter no.3
	Voter *voter4 = new Voter(1012, "Jotaro", "ICT", 2012); //Voter no.4

	BallotBox *box1 = new BallotBox(President); //Ballot Box for President Position
	BallotBox *box2 = new BallotBox(VicePresident); //Ballot Box for VicePresident Position
	BallotBox *box3 = new BallotBox(Secretary); //Ballot Box for Secretary Position
	BallotBox *box4 = new BallotBox(Treasurer); //Ballot Box for Treasurer Position

	BallotPaper *paper1 = new BallotPaper(President); //Ballot Paper 1 for President Position
	BallotPaper *paper2 = new BallotPaper(President); //Ballot Paper 2 for President Position
	BallotPaper *paper3 = new BallotPaper(President); //Ballot Paper 3 for President Position
	BallotPaper *paper4 = new BallotPaper(President); //Ballot Paper 4 for President Position

	BallotPaper *paper5 = new BallotPaper(VicePresident); //Ballot Paper 1 for VicePresident Position
	BallotPaper *paper6 = new BallotPaper(VicePresident); //Ballot Paper 2 for VicePresident Position
	BallotPaper *paper7 = new BallotPaper(VicePresident); //Ballot Paper 3 for VicePresident Position
	BallotPaper *paper8 = new BallotPaper(VicePresident); //Ballot Paper 4 for VicePresident Position

	BallotPaper *paper9 = new BallotPaper(Secretary); //Ballot Paper 1 for Secretary Position
	BallotPaper *paper10 = new BallotPaper(Secretary); //Ballot Paper 2 for Secretary Position
	BallotPaper *paper11 = new BallotPaper(Secretary); //Ballot Paper 3 for Secretary Position
	BallotPaper *paper12 = new BallotPaper(Secretary); //Ballot Paper 4 for Secretary Position

	BallotPaper *paper13 = new BallotPaper(Treasurer); //Ballot Paper 1 for Treasurer Position
	BallotPaper *paper14 = new BallotPaper(Treasurer); //Ballot Paper 2 for Treasurer Position
	BallotPaper *paper15 = new BallotPaper(Treasurer); //Ballot Paper 3 for Treasurer Position
	BallotPaper *paper16 = new BallotPaper(Treasurer); //Ballot Paper 4 for Treasurer Position

	//Adding candidates into lists in ballot papers
	paper1->addCandidate(candidate1); //Adds candidate 1 into list in paper 1
	paper1->addCandidate(candidate2); //Adds candidate 2 into list in paper 1

	paper2->addCandidate(candidate1); //Adds candidate 1 into list in paper 2
	paper2->addCandidate(candidate2); //Adds candidate 2 into list in paper 2

	paper3->addCandidate(candidate1); //Adds candidate 1 into list in paper 3
	paper3->addCandidate(candidate2); //Adds candidate 2 into list in paper 3

	paper4->addCandidate(candidate1); //Adds candidate 1 into list in paper 4
	paper4->addCandidate(candidate2); //Adds candidate 2 into list in paper 4

	paper5->addCandidate(candidate3); //Adds candidate 3 into list in paper 5
	paper5->addCandidate(candidate4); //Adds candidate 4 into list in paper 5

	paper6->addCandidate(candidate3); //Adds candidate 3 into list in paper 6
	paper6->addCandidate(candidate4); //Adds candidate 4 into list in paper 6

	paper7->addCandidate(candidate3); //Adds candidate 3 into list in paper 7
	paper7->addCandidate(candidate4); //Adds candidate 4 into list in paper 7

	paper8->addCandidate(candidate3); //Adds candidate 3 into list in paper 8
	paper8->addCandidate(candidate4); //Adds candidate 4 into list in paper 8

	paper9->addCandidate(candidate5); //Adds candidate 5 into list in paper 9
	paper9->addCandidate(candidate6); //Adds candidate 6 into list in paper 9

	paper10->addCandidate(candidate5); //Adds candidate 5 into list in paper 10
	paper10->addCandidate(candidate6); //Adds candidate 6 into list in paper 10

	paper11->addCandidate(candidate5); //Adds candidate 5 into list in paper 11
	paper11->addCandidate(candidate6); //Adds candidate 6 into list in paper 11

	paper12->addCandidate(candidate5); //Adds candidate 5 into list in paper 12
	paper12->addCandidate(candidate6); //Adds candidate 6 into list in paper 12

	paper13->addCandidate(candidate7); //Adds candidate 7 into list in paper 13
	paper13->addCandidate(candidate8); //Adds candidate 8 into list in paper 13

	paper14->addCandidate(candidate7); //Adds candidate 7 into list in paper 14
	paper14->addCandidate(candidate8); //Adds candidate 8 into list in paper 14

	paper15->addCandidate(candidate7); //Adds candidate 7 into list in paper 15
	paper15->addCandidate(candidate8); //Adds candidate 8 into list in paper 15

	paper16->addCandidate(candidate7); //Adds candidate 7 into list in paper 16
	paper16->addCandidate(candidate8); //Adds candidate 8 into list in paper 16

	//By default, they're all not active. So the CheckActive() method is needed to check if they're eligeble to vote (in this case, they all are)
	voter1->CheckActive(11, 4);
	voter2->CheckActive(11, 3);
	voter3->CheckActive(11, 2);
	voter4->CheckActive(11, 1);

	//Voter 1 votes using Vote() method
	voter1->Vote(paper1, 0);
	voter1->Vote(paper5, 0);
	voter1->Vote(paper9, 1);
	voter1->Vote(paper13, 0);

	//Voter 2 votes using Vote() method
	voter2->Vote(paper2, 0);
	voter2->Vote(paper6, 0);
	voter2->Vote(paper10, 1);
	voter2->Vote(paper14, 0);

	//Voter 3 votes using Vote() method (Note: This voter votes differently than the others)
	voter3->Vote(paper3, 1);
	voter3->Vote(paper7, 1);
	voter3->Vote(paper11, 0);
	voter3->Vote(paper15, 1);

	//Voter 4 votes using Vote() method
	voter4->Vote(paper4, 0);
	voter4->Vote(paper8, 0);
	voter4->Vote(paper12, 1);
	voter4->Vote(paper16, 0);

	box1->addPaper(paper1); //Paper 1 is added into Box 1
	box1->addPaper(paper2); //Paper 2 is added into Box 1
	box1->addPaper(paper3); //Paper 3 is added into Box 1
	box1->addPaper(paper4); //Paper 4 is added into Box 1

	box2->addPaper(paper5); //Paper 5 is added into Box 2
	box2->addPaper(paper6); //Paper 6 is added into Box 2
	box2->addPaper(paper7); //Paper 7 is added into Box 2
	box2->addPaper(paper8); //Paper 8 is added into Box 2

	box3->addPaper(paper9); //Paper 9 is added into Box 3
	box3->addPaper(paper10); //Paper 10 is added into Box 3
	box3->addPaper(paper11); //Paper 11 is added into Box 3
	box3->addPaper(paper12); //Paper 12 is added into Box 3

	box4->addPaper(paper13); //Paper 13 is added into Box 4
	box4->addPaper(paper14); //Paper 14 is added into Box 4
	box4->addPaper(paper15); //Paper 15 is added into Box 4
	box4->addPaper(paper16); //Paper 16 is added into Box 4

	committee1->countVotes(box1); //Election Committee 1 counts the votes in Box 1
	committee1->countVotes(box2); //Election Committee 1 counts the votes in Box 2

	committee2->countVotes(box3); //Election Committee 2 counts the votes in Box 3
	committee2->countVotes(box4); //Election Committee 2 counts the votes in Box 4

	committee1->decideWinner(box1); //Election Committee 1 decides winner for President Position
	committee1->decideWinner(box2); //Election Committee 1 decides winner for VicePresident Position

	committee1->decideWinner(box3); //Election Committee 1 decides winner for Secretary Position
	committee1->decideWinner(box4); //Election Committee 1 decides winner for Treasurer Position

	electionThisYear->announceWinner(box1); //Announces winner for President Position (It should be Candidate Ken)
	electionThisYear->announceWinner(box2); //Announces winner for VicePresident Position (It should be Candidate Lisa)
	electionThisYear->announceWinner(box3); //Announces winner for Secretary Position (It should be Candidate Josuke)
	electionThisYear->announceWinner(box4); //Announces winner for Treasurer Position (It should be Candidate Kira)

	//Deleting papers
	delete paper1;
	delete paper2;
	delete paper3;
	delete paper4;
	delete paper5;
	delete paper6;
	delete paper7;
	delete paper8;
	delete paper9;
	delete paper10;
	delete paper11;
	delete paper12;
	delete paper13;
	delete paper14;
	delete paper15;
	delete paper16;

	//Deleting Ballot Boxes
	delete box1;
	delete box2;
	delete box3;
	delete box4;

	//Deleting Voters
	delete voter1;
	delete voter2;
	delete voter3;
	delete voter4;

	//Deleting Candidates
	delete candidate1;
	delete candidate2;
	delete candidate3;
	delete candidate4;
	delete candidate5;
	delete candidate6;
	delete candidate7;
	delete candidate8;

	//Deleting Election Committees
	delete committee1;
	delete committee2;

	//Deleting Election
	delete electionThisYear;

	//Aquiring input from user from enter key
	std::cin.get();
}