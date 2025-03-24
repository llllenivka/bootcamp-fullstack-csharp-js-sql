import React from 'react';

const FooterItem = () =>
{
    return(
        <div>
            <p className='m-3'>&copy; Авторские права мои {new Date().getFullYear()}</p>
        </div>
    )
}

export default FooterItem;