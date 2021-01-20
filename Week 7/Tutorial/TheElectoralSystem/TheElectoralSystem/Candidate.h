#pragma once

#include <iostream>
#include <string>
#include "member.h"
#include "postType.h"

using namespace std;

//inherits from member class
class Candidate : public Member {
private:
	PostType _post;
	int _voteTotal; //how many voters voted for this candidate
	bool _wonPosition; //whether the candidate has won the position

public:
	Candidate(int studID, string name, string course, int contNo, PostType post);
	PostType getPostType();
	int getVoteTotal();
	void plusVoteTotal();
	bool getWonPosition();
	void setWonPosition(bool result);
};