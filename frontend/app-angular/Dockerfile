# Stage 1
FROM node
RUN mkdir -p /app

WORKDIR /app
ENV PATH /app/node_modules/.bin:$PATH

COPY ./frontend/app-angular/ /app

WORKDIR /app
RUN npm install

# WORKDIR /app
# CMD ng serve --host 0.0.0.0 