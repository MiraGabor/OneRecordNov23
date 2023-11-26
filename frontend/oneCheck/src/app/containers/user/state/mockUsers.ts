import { User } from '../models/user.model';

export const mockUsers: User[] = [
  {
    id: '0',
    name: 'Nikolai Weidner',
    stationCode: 'SIN',
    role: 'export',
  },
  {
    id: '1',
    name: 'Robbert Bobbert',
    stationCode: 'SIN',
    role: 'export',
  },
  {
    id: '2',
    name: 'Dj Shashank',
    stationCode: 'ZRH',
    role: 'transit',
  },
  {
    id: '3',
    name: 'Miroslav Gabbbbor',
    stationCode: 'GVA',
    role: 'transit',
  },
  {
    id: '4',
    name: 'D. Ante',
    stationCode: 'JFK',
    role: 'import',
  },
  {
    id: '5',
    name: 'Dante Favero',
    stationCode: 'JFK',
    role: 'import',
  },
];

// SIN - ZRH -  GVA - JFK
