#include "Candidate.h"

//calls base constructor
Candidate::Candidate(int studID, string name, string course, int contNo, PostType post) : Member::Member(studID, name, course, contNo){
	_studID = studID;
	_name = name;
	_course = course;
	_contNo = contNo;
	_post = post;
	_voteTotal = 0;
	_wonPosition = false;
}

PostType Candidate::getPostType() {
	return _post;
}

int Candidate::getVoteTotal() {
	return _voteTotal;
}

void Candidate::plusVoteTotal() {
	_voteTotal++;
}

bool Candidate::getWonPosition() {
	return _wonPosition;
}

void Candidate::setWonPosition(bool result) {
	_wonPosition = result;
}