#pragma once

#include <iostream>
#include <string>
#include "BallotBox.h"

using namespace std;

class Election {
public:
	Election();
	void announceWinner(BallotBox *box);
};
