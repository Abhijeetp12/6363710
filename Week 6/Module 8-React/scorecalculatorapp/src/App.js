import React from 'react';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore name="Abhijeet Pani" school="Delhi Public School" total={500} goal={5} />
    </div>
  );
}

export default App;
