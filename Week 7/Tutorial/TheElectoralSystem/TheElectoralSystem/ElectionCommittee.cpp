#include "ElectionCommittee.h"

ElectionCommittee::ElectionCommittee(string name) {
	_name = name;
}

string ElectionCommittee::getname() {
	return _name;
}

void ElectionCommittee::countVotes(BallotBox *box) {
	vector<BallotPaper*> paperlist = box->getPapers();

	for (int x = 0; x < paperlist.size(); x++) {

		vector<Candidate*> candidatelist = paperlist[x]->getCandidates();
		int voted = paperlist[x]->getVotedCandidate();

		for (int y = 0; y < candidatelist.size(); y++) {

			candidatelist[voted]->plusVoteTotal();
		}
	}
	
}

//The Ballot Box class is assumed as a grouping of the candidates that are contending for a similar position, not the actual Box itself
void ElectionCommittee::decideWinner(BallotBox *box) {
	vector<BallotPaper*> paper = box->getPapers();
	vector<Candidate*> candidatelist = paper[0]->getCandidates(); //List of Candidates, not the actual Ballot Paper itself

	int winnerposition = 0; //variable that indicates the index of the position winner (will be changed or not changed in loop)

	for (int x = 1; x < candidatelist.size(); x++)
	{
		if (candidatelist[x - 1]->getVoteTotal() < candidatelist[x]->getVoteTotal()) {
			winnerposition = x;
		}
	}

	candidatelist[winnerposition]->setWonPosition(true);
}