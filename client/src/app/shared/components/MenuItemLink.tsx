import { Typography } from "@mui/material";
import type { ReactNode } from "react";
import { NavLink } from "react-router";


export default function MenuItemLink({children, to}: {children: ReactNode, to : string}) {
  return (
    <Typography
        component = {NavLink}
        to= {to}
        sx ={{
            fontSize: '1.2rem',
            textTransform: 'uppercase',
            fontWeight: 'bold',
            color: 'inherit',
            textDecoration: 'none',
            cursor: 'pointer',
            '&.active': {
                color: 'yellow'
            }
        }}
    >
        {children}
    </Typography>
  )
}
