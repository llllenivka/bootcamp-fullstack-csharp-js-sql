import React from 'react';


const ContentItem = (props) =>
{
    return(
        <div>
            {
                props.setOfLabels.map((item, index) =>
                    <div key={item.id} className="card m-3">
                        <img src={`https://via.assets.so/game.jpg?w=${200 + index}&h=100`} className="card-img-top" alt="..."/>
                        <div className="card-body">
                            <h5 className="card-title">{item.title}</h5>
                            <p className="card-text">{item.body}</p>
                        </div>
                    </div>
                )
                
            } 
    </div>
    )
}

export default ContentItem;