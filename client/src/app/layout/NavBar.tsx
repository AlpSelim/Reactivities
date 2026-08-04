import { Group } from '@mui/icons-material'
import { AppBar, Box, Button, Container, Toolbar, Typography} from '@mui/material'
type Props ={
  openForm: () => void;
}

export default function NavBar({ openForm }: Props) {
  return (
   <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static" sx={{ backgroundImage: 'linear-gradient(135deg, #182a73 0%, #218aae 69%, #20a7ac 89%)' }}>
        <Container maxWidth ='xl'>
             <Toolbar sx = {{ display: 'flex', justifyContent: 'space-between' }}>
               <Box sx={{ display: 'flex', alignItems: 'center', gap: 2 }}>
                    <Group fontSize='large' />
                    <Typography variant='h4' sx={{ fontWeight: 'bold' }}>Reactivities</Typography>
               </Box>
               <Box sx={{ display: 'flex', gap: 3 }}>
                    <Typography sx={{ fontSize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold', cursor: 'pointer' }}>
                        Activities
                    </Typography>
                    <Typography sx={{ fontSize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold', cursor: 'pointer' }}>
                        About
                    </Typography>
                    <Typography sx={{ fontSize: '1.2rem', textTransform: 'uppercase', fontWeight: 'bold', cursor: 'pointer' }}>
                        Contact
                    </Typography>
               </Box>
               <Button size= "large" variant="contained" color="warning" onClick={openForm}>Create activity</Button>
             </Toolbar>
        </Container>
      </AppBar>
    </Box>
  )
}
