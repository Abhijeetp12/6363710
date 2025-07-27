import React from "react";
import "../Stylesheets/mystyle.css";

function CalculatorScore(props){
    const {name,school,total,goal}=props;

    const average=total/goal;

    return(
        <div className="score-card">
            <h2>Student Score Report</h2>
            <p>Name:{name}</p>
            <p>School:{school}</p>
            <p>Total Marks:{total}</p>
            <p>Subjects:{goal}</p>
            <p>Average Score:{average.toFixed(2)}</p>
        </div>

    );
}

export default CalculatorScore;