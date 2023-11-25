import { Answer } from './answer';

export interface Question {
  checks: any[]; // todo
  skeletonIndicator: boolean;
  checkTemplate: any; // todo
  answer: Answer;
  answerOptionsText: string;
  answerOptionsValue: string;
  longText: string;
  questionNumber: string;
  questionSection: string;
  shortText: string;
}
