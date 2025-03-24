import React from 'react';

const item = ["Элемент1", "Элемент2", "Элемент3", "Элемент4" ,"Элемент5", "Элемент6"];

const ContentItem = () =>
{
    return(
        <div>
    

        {
          item.map(i => 
            <div className="card m-3">
              <img src="http://dummyimage.com/200" className="card-img-top" alt="..."/>
              <div className="card-body">
                <h5 className="card-title">{i}</h5>
                <p className="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
              </div>
            </div>
          )
        }
  
      
    </div>
    )
}

export default ContentItem;